$(window).scroll(function () {
  if ($(window).scrollTop() > 0) {
    $(".wrapper").addClass("small-header");
  } else {
    $(".wrapper").removeClass("small-header");
  }
});

var slider = document.getElementById("slider");

noUiSlider.create(slider, {
  start: [1, 10],
  connect: true,
  range: {
    min: 1,
    max: 10,
  },
});

let minVal = document.querySelector("#min_price");
let maxVal = document.querySelector("#max_price");

slider.noUiSlider.on("update", function () {
  let handle = slider.noUiSlider.get();
  minVal.innerText = Math.round(handle[0]);
  maxVal.innerText = Math.round(handle[1]);
  aaplyFilter();
});

// date reset
let resetBtnDate = document.querySelector(".resetBtnDate");
resetBtnDate.addEventListener("click", () => {
  document.querySelector("#dk1-combobox").innerText = "month";
  document.querySelector("#month_start").value = "month";
  document
    .querySelector("#dk1-combobox")
    .setAttribute("aria-activedescendant", "dk-month");
  let liTag = document.querySelectorAll("#dk1-listbox>li");
  liTag.forEach((tag) => {
    tag.classList.remove("dk-option-selected");
  });
  document.querySelector("#dk1-month").classList.add("dk-option-selected");

  // dk-2
  document.querySelector("#dk2-combobox").innerText = "month";
  document.querySelector("#month_end").value = "month";
  document
    .querySelector("#dk2-combobox")
    .setAttribute("aria-activedescendant", "dk-month");
  let liTag2 = document.querySelectorAll("#dk2-listbox>li");
  liTag2.forEach((tag) => {
    tag.classList.remove("dk-option-selected");
  });
  document.querySelector("#dk2-month").classList.add("dk-option-selected");

  // dk-3
  document.querySelector("#dk3-combobox").innerText = "dd";
  document.querySelector("#day_start").value = "dd";
  document
    .querySelector("#dk3-combobox")
    .setAttribute("aria-activedescendant", "dk-dd");
  let liTag3 = document.querySelectorAll("#dk3-listbox>li");
  liTag3.forEach((tag) => {
    tag.classList.remove("dk-option-selected");
  });
  document.querySelector("#dk3-dd").classList.add("dk-option-selected");

  //dk-4
  document.querySelector("#dk4-combobox").innerText = "dd";
  document.querySelector("#day_end").value = "dd";
  document
    .querySelector("#dk4-combobox")
    .setAttribute("aria-activedescendant", "dk-dd");
  let liTag4 = document.querySelectorAll("#dk4-listbox>li");
  liTag4.forEach((tag) => {
    tag.classList.remove("dk-option-selected");
  });
  document.querySelector("#dk4-dd").classList.add("dk-option-selected");

  //dk-5
  document.querySelector("#dk5-combobox").innerText = "yyyy";
  document.querySelector("#year_start").value = "yyyy";
  document
    .querySelector("#dk5-combobox")
    .setAttribute("aria-activedescendant", "dk-yyyy");
  let liTag5 = document.querySelectorAll("#dk5-listbox>li");
  liTag5.forEach((tag) => {
    tag.classList.remove("dk-option-selected");
  });
  document.querySelector("#dk5-yyyy").classList.add("dk-option-selected");

  // dk-6
  document.querySelector("#dk6-combobox").innerText = "yyyy";
  document.querySelector("#year-end").value = "yyyy";
  document
    .querySelector("#dk6-combobox")
    .setAttribute("aria-activedescendant", "dk-yyyy");
  let liTag6 = document.querySelectorAll("#dk6-listbox>li");
  liTag6.forEach((tag) => {
    tag.classList.remove("dk-option-selected");
  });
  document.querySelector("#dk6-yyyy").classList.add("dk-option-selected");

  aaplyFilter();
});

// range reset
let resetBtnRange = document.querySelector(".resetBtnRange");
resetBtnRange.addEventListener("click", () => {
  minVal.innerText = 1;
  maxVal.innerText = 10;
  slider.noUiSlider.set(["1.00", "10.00"]);
});

function aaplyFilter() {
  let fValue = 0;
  let filterVal = document.querySelector(".filterVal");

  if (
    document.querySelector("#inlineCheckbox1").checked === true ||
    document.querySelector("#teach").checked === true ||
    document.querySelector("#intern1").checked === true
  ) {
    fValue = fValue + 1;
  }

  if (document.querySelector("#searchCountry").value.length > 0) {
    fValue = fValue + 1;
  }

  if (document.querySelector("#activitySelect").value !== "Select Activity") {
    fValue = fValue + 1;
  }

  if (
    document.querySelector("#month_start").value !== "month" ||
    document.querySelector("#day_start").value !== "dd" ||
    document.querySelector("#year_start").value !== "yyyy" ||
    document.querySelector("#month_end").value !== "month" ||
    document.querySelector("#day_end").value !== "dd" ||
    document.querySelector("#year-end").value !== "yyyy"
  ) {
    fValue = fValue + 1;
  }

  if (minVal.innerHTML > 1 || maxVal.innerHTML < 10) {
    fValue = fValue + 1;
  }

  if (document.querySelector("#min_age").value !== "--") {
    fValue = fValue + 1;
  }
  filterVal.innerText = fValue;
}
