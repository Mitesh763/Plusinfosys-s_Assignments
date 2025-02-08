const products = [
  { id: 1, image: "../images/shirt.png", desc: "Formal Gray Shirt", price: 40 },
  { id: 2, image: "../images/saree.png", desc: "Pink Saree", price: 30 },
  { id: 3, image: "../images/dress.png", desc: "Beautiful Dress", price: 20 },
  {
    id: 4,
    image: "../images/babydress.png",
    desc: "Cute Baby Dress",
    price: 10,
  },
];

const itemList = document.getElementById("itemList");

// Generate product rows dynamically
products.forEach((product) => {
  const row = document.createElement("tr");
  row.innerHTML = `
      <td><input type="checkbox" class="form-check-input" id="${product.id}ItemCheck" /></td>
      <td><img src="${product.image}" width="50" alt="${product.desc}" class="img-fluid" /></td>
      <td>${product.desc}</td>
      <td>
        <div class="d-flex align-items-center justify-content-center">
          $ <input type="number" class="form-control w-50 text-center ms-1" disabled value="${product.price}" />
        </div>
      </td>
      <td><input type="number" class="form-control w-50 mx-auto text-center" disabled min="0" id="${product.id}ItemQuantity" /></td>
      <td>
        <div class="d-flex align-items-center justify-content-center">
          $ <input type="number" class="form-control w-50 text-center ms-1" disabled id="${product.id}ItemTotal" />
        </div>
      </td>
      <td><button class="btn btn-danger" id="${product.id}ItemRemove"><i class="fa fa-remove"></i></button></td>
    `;
  itemList.appendChild(row);
});

document.addEventListener("DOMContentLoaded", function () {
  const table = document.querySelector("tbody");

  table.addEventListener("change", function (event) {
    if (event.target.matches("input[type='checkbox']")) {
      const row = event.target.closest("tr");
      const quantityInput = row.querySelector("td:nth-child(5) input");
      const totalInput = row.querySelector("td:nth-child(6) input");

      if (event.target.checked) {
        quantityInput.removeAttribute("disabled");
      } else {
        quantityInput.setAttribute("disabled", true);
        quantityInput.value = "";
        totalInput.value = "";
      }
      updateCheckout();
    }
  });

  table.addEventListener("input", function (event) {
    if (event.target.matches("input[type='number']")) {
      event.target.value = event.target.value.replace(/[^0-9]/g, "");

      updateItemTotal(event.target);
      updateCheckout();
    }
  });

  table.addEventListener("keydown", function (event) {
    if (event.target.matches("input[type='number']") && event.key === ".") {
      event.preventDefault();
    }
  });

  table.addEventListener("click", function (event) {
    if (event.target.matches("button")) {
      const row = event.target.closest("tr");
      row.remove();
      updateCheckout();
    }
  });

  function updateItemTotal(quantityInput) {
    const row = quantityInput.closest("tr");
    const price = parseFloat(row.querySelector("td:nth-child(4) input").value);
    const quantity = parseInt(quantityInput.value) || 0;
    const itemTotal = price * quantity;

    row.querySelector("td:nth-child(6) input").value = itemTotal.toFixed(2);
  }

  function updateCheckout() {
    let totalItems = 0;
    let subTotal = 0;

    document.querySelectorAll("tbody tr").forEach((row) => {
      const quantityInput = row.querySelector("td:nth-child(5) input");
      const totalInput = row.querySelector("td:nth-child(6) input");

      if (quantityInput && totalInput && !quantityInput.disabled) {
        let quantity = parseInt(quantityInput.value) || 0;
        let itemTotal = parseFloat(totalInput.value) || 0;

        totalItems += quantity;
        subTotal += itemTotal;
      }
    });

    let gst = subTotal * 0.18;
    let totalAmount = subTotal + gst;

    document.getElementById("totalItems").value = totalItems;
    document.getElementById("subTotal").value = subTotal.toFixed(2);
    document.getElementById("gst").value = gst.toFixed(2);
    document.getElementById("totalAmount").value = totalAmount.toFixed(2);
  }

  const checkout = document.getElementById("checkout");
  checkout.addEventListener("click", function () {
    const totalItems = document.getElementById("totalItems").value || 0;
    const totalAmount = document.getElementById("totalAmount").value || 0;

    const today = new Date();
    const billDate = today
      .toLocaleDateString("en-GB", {
        day: "2-digit",
        month: "2-digit",
        year: "numeric",
      })
      .replace(" ", "/"); // Format as YYYY-MM-DD

    const deliveryDate = new Date(today);
    deliveryDate.setFullYear(today.getFullYear() + 1);
    deliveryDate.setDate(today.getDate() + 1);
    const deliveryDateFormatted = deliveryDate.toLocaleDateString("en-GB", {
      day: "2-digit",
      month: "short",
      year: "numeric",
    }); // Format as YYYY-MM-DD
  });
});
