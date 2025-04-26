let check1 = document.querySelector(".check1");
let inputEnable1 = document.querySelector(".inputEnable1");
let inputEnable2 = document.querySelector(".inputEnable2");
let inputEnable3 = document.querySelector(".inputEnable3");
let inputEnable4 = document.querySelector(".inputEnable4");
let totalItems = document.querySelector(".totalItems");
let totalPrice = document.querySelector(".totalPrice");
let gst = document.querySelector(".gst");
let total = document.querySelector(".total");

let quantity1;
let quantity2;
let quantity3;
let quantity4;
let pItem1;
let pItem4;
let pItem2;
let pItem3;

check1.addEventListener("click", () => {
  if (check1.checked === true) {
    inputEnable1.style.cursor = "text";
    inputEnable1.disabled = false;
  } else {
    inputEnable1.style.cursor = "not-allowed";
    inputEnable1.disabled = true;
  }
});

function displaySingleTotal1() {
  if (inputEnable1.value > 0) check1.disabled = true;
  else check1.disabled = false;
  updatePrevious(quantity1, pItem1);
  let item1Price = Number(document.querySelector(".item1Price").innerText);
  quantity1 = inputEnable1.value;
  pItem1 = document.getElementById("singleSum1").innerText = Number(
    item1Price * quantity1
  );
  calTotal(quantity1, pItem1);
}

let remove1 = document.querySelector(".remove1");
let item1 = document.querySelector(".item1");
remove1.addEventListener("click", () => {
  removeTotal(inputEnable1.value, pItem1);
  item1.style.display = "none";
});

// item2
let check2 = document.querySelector(".check2");
check2.addEventListener("click", () => {
  if (check2.checked === true) {
    inputEnable2.style.cursor = "text";
    inputEnable2.disabled = false;
  } else {
    inputEnable2.style.cursor = "not-allowed";
    inputEnable2.disabled = true;
  }
});
function displaySingleTotal2() {
  if (inputEnable2.value > 0) check2.disabled = true;
  else check2.disabled = false;
  updatePrevious(quantity2, pItem2);
  let item2Price = Number(document.querySelector(".item2Price").innerText);
  quantity2 = inputEnable2.value;
  pItem2 = document.querySelector("#singleSum2").innerText = Number(
    item2Price * quantity2
  );
  calTotal(quantity2, pItem2);
}
let remove2 = document.querySelector(".remove2");
let item2 = document.querySelector(".item2");
remove2.addEventListener("click", () => {
  removeTotal(inputEnable2.value, pItem2);
  item2.style.display = "none";
});

// item3
let check3 = document.querySelector(".check3");
check3.addEventListener("click", () => {
  if (check3.checked === true) {
    inputEnable3.style.cursor = "text";
    inputEnable3.disabled = false;
  } else {
    inputEnable3.style.cursor = "not-allowed";
    inputEnable3.disabled = true;
  }
});
function displaySingleTotal3() {
  if (inputEnable3.value > 0) check3.disabled = true;
  else check3.disabled = false;
  updatePrevious(quantity3, pItem3);
  let item3Price = Number(document.querySelector(".item3Price").innerText);
  quantity3 = inputEnable3.value;
  pItem3 = document.querySelector("#singleSum3").innerText = Number(
    item3Price * quantity3
  );
  calTotal(quantity3, pItem3);
}
let remove3 = document.querySelector(".remove3");
let item3 = document.querySelector(".item3");
remove3.addEventListener("click", () => {
  removeTotal(inputEnable3.value, pItem3);
  item3.style.display = "none";
});

// item4
let check4 = document.querySelector(".check4");
check4.addEventListener("click", () => {
  if (check4.checked === true) {
    inputEnable4.style.cursor = "text";
    inputEnable4.disabled = false;
  } else {
    inputEnable4.style.cursor = "not-allowed";
    inputEnable4.disabled = true;
  }
});
function displaySingleTotal4() {
  if (inputEnable4.value > 0) check4.disabled = true;
  else check4.disabled = false;
  updatePrevious(quantity4, pItem4);
  let item4Price = Number(document.querySelector(".item4Price").innerText);
  quantity4 = inputEnable4.value;
  pItem4 = document.querySelector("#singleSum4").innerText = Number(
    item4Price * quantity4
  );
  calTotal(quantity4, pItem4);
}
let remove4 = document.querySelector(".remove4");
let item4 = document.querySelector(".item4");
remove4.addEventListener("click", () => {
  removeTotal(inputEnable4.value, pItem4);
  item4.style.display = "none";
});

let totalSubPrice = document.querySelector(".totalPrice");
document.querySelector(".gst").innerText = totalSubPrice.innerText;

function confirmOrder() {
  console.log(document.querySelector(".totaltems"));
  if (document.querySelector(".totalItems").innerText > 0) {
    const date = new Date();
    alert(
      `Total item: ` +
        document.querySelector(".totalItems").innerText +
        ` \n Total Amount: ` +
        document.querySelector(".total").innerText +
        ` \n Bill Date: ` +
        date.getDate() +
        `/` +
        (date.getMonth() + 1) +
        `/` +
        date.getFullYear() +
        ` \n Delivery Date: ` +
        date.getDate() +
        ` ` +
        date.toLocaleString("default", { month: "short" }) +
        ` ` +
        (date.getFullYear() + 1) +
        `\n\n\n Confirm order? `
    );
  } else {
    alert("No one item Select!");
  }
}

function removeTotal(inputValue, price) {
  if (inputValue > 0 && price > 0) {
    totalItems.innerText = Number(
      Number(document.querySelector(".totalItems").innerText) -
        Number(inputValue)
    );
    totalPrice.innerText = Number(
      Math.round(
        Number(document.querySelector(".totalPrice").innerText) - price
      )
    );
    calGSTandTotal();
  }
}

function calTotal(quantity, price) {
  totalItems.innerText = Number(
    Number(totalItems.innerText) + Number(quantity)
  );
  totalPrice.innerText = Number(Number(totalPrice.innerText) + price);
  calGSTandTotal();
}

function calGSTandTotal() {
  document.querySelector(".gst").innerText = totalPrice.innerText * 0.18;
  total.innerText =
    Number(document.querySelector(".gst").innerText) +
    Number(document.querySelector(".totalPrice").innerText);
}

function updatePrevious(quantity, price) {
  if (quantity > 0) {
    totalItems.innerText = Number(
      Number(totalItems.innerText) - Number(quantity)
    );
  }
  if (price > 0) {
    totalPrice.innerText = Number(Number(totalPrice.innerText) - price);
  }
}
