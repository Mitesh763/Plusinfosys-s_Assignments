$(document).ready(function () {
  $(".slider1").owlCarousel({
    margin: 10,
    nav: false,
    responsive: {
      0: {
        items: 1,
      },
      500: {
        items: 2,
      },
      1000: {
        items: 3,
      },
      1500: {
        items: 4,
      },
    },
  });

  const carousel = $(".slider1");

  $("#prevBtn").on("click", function () {
    carousel.trigger("prev.owl.carousel");
  });

  $("#nextBtn").on("click", function () {
    carousel.trigger("next.owl.carousel");
    x;
  });
});

$(document).ready(function () {
  $(".slider2").owlCarousel({
    margin: 10,
    nav: false,
    responsive: {
      0: {
        items: 1,
      },
      500: {
        items: 2,
      },
      1000: {
        items: 3,
      },
      1500: {
        items: 4,
      },
    },
  });

  const carousel = $(".slider2");

  $("#prevBtn1").on("click", function () {
    carousel.trigger("prev.owl.carousel");
  });

  $("#nextBtn1").on("click", function () {
    carousel.trigger("next.owl.carousel");
    x;
  });
});
