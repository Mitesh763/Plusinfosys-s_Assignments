const state1 = ["Gujrat", "Rajsthan", "Maharashtra"];

const cities1 = [
  ["Amreli", "Ahemadabad", "Junagadh", "Surat", "Rajkot"],
  ["Jaipur", "Jaisalmer", "Bikaner", "Chittorgarh"],
  ["Mumbai", "Pune", "Thane", "Nashik", "Solapur", "Ratnagiri"],
];

let missingId = "";

function submitValidation(idArr) {
  if (document.getElementById(idArr[0]).value.length <= 0) {
    document.getElementById(idArr[0]).classList.add("focusEle");
    alert(idArr[0] + " is required");
    return false;
    // missingId += "\n" + idArr[0];
  }
  if (document.getElementById(idArr[1]).value.length <= 0) {
    document.getElementById(idArr[1]).classList.add("focusEle");
    alert(idArr[1] + " is required");
    return false;
    // missingId += "\n" + idArr[1];
  }
  if (document.getElementById(idArr[2]).value.length <= 0) {
    document.getElementById(idArr[2]).classList.add("focusEle");
    alert(idArr[2] + " is required");
    // missingId += "\n" + idArr[2];
    return false;
  }

  let rege = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
  let mail = document.getElementById(idArr[2]).value;
  if (!rege.test(mail)) {
    document.getElementById(idArr[2]).classList.add("focusEle");
    alert("Email address not Valid!");
    return false;
  }

  if (document.getElementById(idArr[3]).value.length <= 0) {
    document.getElementById(idArr[3]).classList.add("focusEle");
    alert(idArr[3] + " is required");
    return false;
    // missingId += "\n" + idArr[3];
  }
  let regePass =
    /^(?=.*[a-zA-Z])(?=.*\d)(?=.*[!@#$%^&*()_+])[A-Za-z\d][A-Za-z\d!@#$%^&*()_+]{7,19}$/;
  let password = document.getElementById(idArr[3]).value;
  if (!regePass.test(password)) {
    document.getElementById(idArr[3]).classList.add("focusEle");
    alert(
      "Password must contain 1 capital, 1 small, 1 special character and 1 numeric"
    );
    return false;
  }
  if (document.getElementById(idArr[4]).value.length <= 0) {
    document.getElementById(idArr[4]).classList.add("focusEle");
    alert(idArr[4] + " is required");
    return false;
    // missingId += "\n" + idArr[4];
  }
  let regeDate = /^(0[1-9]|1[0-2])\/(0[1-9]|1\d|2\d|3[01])\/(19|20)\d{2}$/;
  let myDate = document.getElementById(idArr[4]).value;
  if (!regeDate.test(myDate)) {
    document.getElementById(idArr[4]).classList.add("focusEle");
    alert("Birth date must be in MM/DD/YYYY format!");
    return false;
  }
  if (document.getElementById(idArr[5]).value.length <= 0) {
    document.getElementById(idArr[5]).classList.add("focusEle");
    alert(idArr[5] + " is required");
    return false;
    // missingId += "\n" + idArr[5];
  }
  let isCheck = false;
  if (
    document.querySelector(".mGender").checked ||
    document.querySelector(".fGender").checked
  ) {
    isCheck = true;
  }
  if (!isCheck) {
    alert("Select your gender");
    return false;
  }
  let interestCheck = false;
  if (
    document.querySelector(".sport").checked === true ||
    document.querySelector(".dance").checked === true ||
    document.querySelector(".read").checked === true ||
    document.querySelector(".other").checked === true
  ) {
    document.querySelector("#interest").required = false;
    interestCheck = true;
  }
  if (!interestCheck) {
    alert("Select at least one interest");
    return false;
  }
  console.log(document.getElementById("inp").value.length);
  if (
    document.getElementById("other").checked === true &&
    document.getElementById("inp").value.length <= 0
  ) {
    document.getElementById("inp").classList.add("focusEle");
    alert("Please enter your other interest");
    return false;
    // missingId += "\n" + idArr[7];
  }
  if (document.getElementById(idArr[8]).value.length <= 0) {
    document.getElementById(idArr[8]).classList.add("focusEle");
    alert("Job State 1 is required");
    return false;
    // missingId += "\n" + idArr[8];
  }
  if (document.getElementById(idArr[9]).value.length <= 0) {
    document.getElementById(idArr[9]).classList.add("focusEle");
    alert("Job City 1 is required");
    // return false;
    // missingId += "\n" + idArr[9];
  }

  // idArr.map((id) => {
  //   console.log(id);
  //   if (document.getElementById(id).value.length <= 0) {
  //     document.getElementById(id).classList.add("focusEle");
  //     alert(id + " is required");
  //     return false;
  //     // missingId += "\n" + id;
  //   } else {
  //     document.getElementById(id).classList.remove("focusEle");
  //   }
  // });

  // if (missingId) {
  //   alert(missingId + "\n\n are required fields");
  //   missingId = "";
  //   return false;
  // }

  // let isCheck = false;
  // if (
  //   document.querySelector(".mGender").checked ||
  //   document.querySelector(".fGender").checked
  // ) {
  //   isCheck = true;
  // }
  // if (!isCheck) {
  //   alert("Select your gender");
  //   return false;
  // }

  // let interestCheck = false;
  // if (
  //   document.querySelector(".sport").checked === true ||
  //   document.querySelector(".dance").checked === true ||
  //   document.querySelector(".read").checked === true ||
  //   document.querySelector(".other").checked === true
  // ) {
  //   interestCheck = true;
  // }
  // if (!interestCheck) {
  //   alert("Select at least one interest");
  //   // return false;
  // }

  // let rege = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
  // let mail = document.getElementById(idArr[2]).value;
  // if (!rege.test(mail)) {
  //   document.getElementById(idArr[2]).classList.add("focusEle");
  //   alert("Email address not Valid!");
  // }

  // let regePass =
  //   /^(?=.*[a-zA-Z])(?=.*\d)(?=.*[!@#$%^&*()_+])[A-Za-z\d][A-Za-z\d!@#$%^&*()_+]{7,19}$/;
  // let password = document.getElementById(idArr[3]).value;
  // if (!regePass.test(password)) {
  //   document.getElementById(idArr[3]).classList.add("focusEle");
  //   alert(
  //     "Password must contain 1 capital, 1 small, 1 special character and 1 numeric"
  //   );
  // }

  // let regeDate = /^(0[1-9]|1[0-2])\/(0[1-9]|1\d|2\d|3[01])\/(19|20)\d{2}$/;
  // let myDate = document.getElementById(idArr[4]).value;
  // if (!regeDate.test(myDate)) {
  //   document.getElementById(idArr[4]).classList.add("focusEle");
  //   alert("Birth date must be in MM/DD/YYYY format!");
  // }
}

let otherBtn = document.querySelector(".otherBtn");
otherBtn.addEventListener("click", () => {
  if (otherBtn.checked === true) {
    document.querySelector(".otherBtnArea").style.display = "block";
    document.querySelector(".inp").required = true;
  } else {
    document.querySelector(".otherBtnArea").style.display = "none";
    document.querySelector(".inp").required = false;
  }
});

let termCheck = document.querySelector("#checked1");
termCheck.addEventListener("click", () => {
  if (termCheck.checked === true) {
    document.querySelector("#submitBtn").disabled = false;
    document.querySelector("#submitBtn").style.cursor = "pointer";
  } else {
    document.querySelector("#submitBtn").disabled = true;
    document.querySelector("#submitBtn").style.cursor = "not-allowed";
  }
});

function selecteHandler() {
  let jobState1 = document.querySelector("#jobState1");

  let jobCity1 = document.querySelector("#jobCity1");
  jobCity1.required = true;
  jobCity1.disabled = false;
  let idx = state1.indexOf(jobState1.value);

  jobCity1.innerHTML = "";

  let newCity = cities1[idx];

  for (let i = 0; i < newCity.length; i++) {
    myOption = document.createElement("option");
    myOption.text = newCity[i];
    jobCity1.appendChild(myOption);
  }
}

function selecteHandler2() {
  let jobState2 = document.querySelector("#jobState2");

  let jobCity2 = document.querySelector("#jobCity2");
  jobCity2.required = true;
  jobCity2.disabled = false;
  let idx = state1.indexOf(jobState2.value);

  jobCity2.innerHTML = "";

  let newCity = cities1[idx];

  for (let i = 0; i < newCity.length; i++) {
    myOption = document.createElement("option");
    myOption.text = newCity[i];
    jobCity2.appendChild(myOption);
  }
}

function removeBdr() {
  let allInputs = document.querySelectorAll("input");
  allInputs.forEach((input) => {
    input.classList.remove("focusEle");
  });
  let txtArea = document.querySelector("textarea");
  txtArea.classList.remove("focusEle");
  let selectes = document.querySelector("select");
  selectes.classList.remove("focusEle");
}
