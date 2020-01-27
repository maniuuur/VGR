$('.owl-carousel').owlCarousel({
    loop: true,
    nav: true,
    dots: false,
    mouseDrag: true,
    margin: 10,
    responsiveClass: true,
    responsive: {
        0: {
            items: 1,            
        },
        600: {
            items: 3,
        },
        1000: {
            items: 4,
        },
        1200: {
            items: 5,
        }
    }
});