$(".carousel").owlCarousel({
  loop: true,
  margin: 45,
  nav: true,
  navText: [
    "<i class='fas fa-chevron-right'><</i>",
    "<i class='fas fa-chevron-left'>></i>",
  ],
  responsive: {
    0: {
      items: 1,
    },
    1000: {
      items: 1,
    },
  },
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

  let newBtn = document.createElement("button");
  newBtn.textContent = "Login";
  pages.appendChild(newBtn);
});

crossMenu.addEventListener("click", () => {
  humbargor.classList.remove("displayNone");
  crossMenu.classList.add("displayNone");
  pages.classList.add("pages");
  pages.classList.remove("pagesOverlay");
  newBtn.remove;
});

function changeProp() {
  console.log("checked!");
  checked.style.backgroundColor = "red";
}

let checked = document.querySelectorAll(".form-check-input");

checked.addEventListener("click", changeProp);
