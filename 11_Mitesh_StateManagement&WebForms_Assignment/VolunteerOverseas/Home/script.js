$(window).scroll(function () {
  if ($(window).scrollTop() > 0) {
    $(".wrapper").addClass("small-header");
    document.querySelector(".introDiscription").style.paddingTop = "20%";
    document.querySelector(".introDiscription").style.marginTop = "0";
  } else {
    $(".wrapper").removeClass("small-header");
    document.querySelector(".introDiscription").style.paddingTop = "0";
    document.querySelector(".introDiscription").style.marginTop = "16rem";
  }
});

$(document).ready(function () {
  $(".slider1").owlCarousel({
    margin: 10,
    nav: false,
    responsive: {
      0: {
        items: 1,
      },
      650: {
        items: 2,
      },
      900: {
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

// second slider
$(document).ready(function () {
  $(".slider2").owlCarousel({
    margin: 10,
    nav: false,
    responsive: {
      0: {
        items: 1,
      },
      650: {
        items: 2,
      },
      900: {
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

// third slider
$(document).ready(function () {
  $(".slider3").owlCarousel({
    margin: 10,
    responsive: {
      0: {
        items: 1,
      },
      650: {
        items: 2,
      },
      900: {
        items: 3,
      },
      1500: {
        items: 4,
      },
    },
  });

  const carousel = $(".slider3");

  $("#prevBtn3").on("click", function () {
    carousel.trigger("prev.owl.carousel");
  });

  $("#nextBtn3").on("click", function () {
    carousel.trigger("next.owl.carousel");
    x;
  });
});

let humbargor = document.querySelector(".humburgor");
let pages = document.querySelector(".pages");
let crossMenu = document.querySelector(".crossMenu");
let loginBtn = document.querySelector(".loginBtn");

humbargor.addEventListener("click", () => {
  humbargor.classList.add("displayNone");
  crossMenu.classList.remove("displayNone");
  pages.classList.remove("pages");
  pages.classList.add("pagesOverlay");
  const newBtn = document.createElement("button");
});

crossMenu.addEventListener("click", () => {
  humbargor.classList.remove("displayNone");
  crossMenu.classList.add("displayNone");
  pages.classList.add("pages");
  pages.classList.remove("pagesOverlay");
});

window.onload = function () {
  const firstEnabledInput = document.querySelector("input");
  if (firstEnabledInput) {
    firstEnabledInput.focus();
    firstEnabledInput.style.caretColor = "red";
    firstEnabledInput.style.fontSize = "15px";
  }
};
