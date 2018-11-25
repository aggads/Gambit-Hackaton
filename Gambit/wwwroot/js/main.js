$('.center').slick({
    centerMode: true,
    centerPadding: '60px',
    slidesToShow: 5,
    prevArrow: '<div class="columns is-desktop is-mobile"><div class="column is-offset-11 mt_20"><button type="button" class="slick-prev button is-info marginButton">Next</button></div></div>',
    nextArrow: '<button type="button" class="slick-next button is-info marginBottomPrev">Previous</button>',
    speed: 1000,
    responsive: [
      {
        breakpoint: 768,
        settings: {
          arrows: false,
          centerMode: true,
          centerPadding: '40px',
          slidesToShow: 5
        }
      },
      {
        breakpoint: 100,
        settings: {
          arrows: true,
          centerMode: true,
          centerPadding: '40px',
          slidesToShow: 5
        }
      }
    ]
  });