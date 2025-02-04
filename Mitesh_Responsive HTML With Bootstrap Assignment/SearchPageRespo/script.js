$(window).scroll(function () {
  if ($(window).scrollTop() > 0) {
    $(".wrapper").addClass("small-header");
  } else {
    $(".wrapper").removeClass("small-header");
  }
});

$(".more-filters-btn").click(function () {
  $this.find(".more-filters").slideToggle();
});

$(document).ready(function () {
  // range selection
  $("#min_price,#max_price").on("change", function () {
    var min_price_range = parseInt($("#min_price").val());

    var max_price_range = parseInt($("#max_price").val());

    if (min_price_range > max_price_range) {
      $("#max_price").val(min_price_range);
    }

    $("#slider-range").slider({
      values: [min_price_range, max_price_range],
    });
  });

  $("#min_price,#max_price").on("paste keyup", function () {
    var min_price_range = parseInt($("#min_price").val());

    var max_price_range = parseInt($("#max_price").val());

    if (min_price_range == max_price_range) {
      max_price_range = min_price_range + 100;

      $("#min_price").val(min_price_range);
      $("#max_price").val(max_price_range);
    }

    $("#slider-range").slider({
      values: [min_price_range, max_price_range],
    });
  });

  $(document).ready(function () {
    $("#min_price,#max_price").on("change", function () {
      $("#price-range-submit").show();

      var min_price_range = parseInt($("#min_price").val());

      var max_price_range = parseInt($("#max_price").val());

      if (min_price_range > max_price_range) {
        $("#max_price").val(min_price_range);
      }

      $("#slider-range").slider({
        values: [min_price_range, max_price_range],
      });
    });

    $("#min_price,#max_price").on("paste keyup", function () {
      $("#price-range-submit").show();

      var min_price_range = parseInt($("#min_price").val());

      var max_price_range = parseInt($("#max_price").val());

      if (min_price_range == max_price_range) {
        max_price_range = min_price_range + 100;

        $("#min_price").val(min_price_range);
        $("#max_price").val(max_price_range);
      }

      $("#slider-range").slider({
        values: [min_price_range, max_price_range],
      });
    });

    $(function () {
      $("#slider-range").slider({
        range: true,
        orientation: "horizontal",
        min: 1,
        max: 10,
        values: [1, 10],
        step: 1,

        slide: function (event, ui) {
          if (ui.values[0] == ui.values[1]) {
            return false;
          }

          $("#min_price").val(ui.values[0]);
          $("#max_price").val(ui.values[1]);
        },
      });

      $("#min_price").val($("#slider-range").slider("values", 0));
      $("#max_price").val($("#slider-range").slider("values", 1));
    });
  });
});
