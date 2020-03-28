//mobile-nav display functionality
$('.mobileNav').on('click', () => {
    if( $('.navigation__list').css('display') === 'none' ) {
        $('.navigation__list').css('display', 'flex');
    } else {
        $('.navigation__list').css('display', 'none');
    }
});

$(window).resize(() => {
    if( $(window).innerWidth() > 950 ) {
        $(".navigation__list").css("display", "flex");
    } else if( $(window).innerWidth() < 950 ) {
        $(".navigation__list").css("display", "none");
    }
})