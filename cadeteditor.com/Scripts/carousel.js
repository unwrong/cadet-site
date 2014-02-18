var $carousel, $item, timer;

$(function () {
            
    $carousel = $('#carousel');

    $carousel.on('slide.bs.carousel', function () {
        clearInterval(timer);
    });

    $carousel.on('slid.bs.carousel', function() {
        updateGifs();
    });

    updateGifs();
});

function updateGifs() {

    if ($item) {
        // set the previous item (if any) to looping
        swapGifs($item);
    } else {
        // this is the first img, so show it.
        $($carousel.find('.item.active img')[0]).show();
    }

    $item = $carousel.find('.item.active');

    if (!$item.data('looping')) {
        var loopAt = parseInt($item.data('loop-at'));
        
        timer = setTimeout(function() {
            swapGifs($item);
            clearInterval(timer);
        }, loopAt);
    }
}

function swapGifs($item) {
    $($item.find('img')[0]).hide();
    $($item.find('img')[1]).show();
    $item.data('looping', true);
}
