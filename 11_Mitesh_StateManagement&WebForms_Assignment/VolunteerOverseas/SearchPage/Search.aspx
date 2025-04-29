<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="VolunteerOverseas.SearchPage.Sarch" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <script src="https://code.jquery.com/jquery-1.11.0.min.js"></script>

    <link
        rel="stylesheet"
        href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" />
    <link
        rel="stylesheet"
        href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.css"
        type="text/css"
        media="all" />

    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script
        src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"
        type="text/javascript"></script>
    <script
        src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"
        type="text/javascript"></script>

    <link
        rel="stylesheet"
        href="https://code.jquery.com/ui/1.14.1/themes/base/jquery-ui.css" />
    <!-- swiper -->
    <link
        rel="stylesheet"
        href="https://cdn.jsdelivr.net/npm/swiper@11/swiper-bundle.min.css" />
    <!-- swiper -->

    <!-- dropkick -->
    <link rel="stylesheet" href="./css/dropkick.css" />
    <script src="./js/dropkick.js"></script>
    <!-- dropkick -->

    <link rel="stylesheet" href="search.css" />
    <link rel="stylesheet" href="./css/nouislider.min.css" />

    <title>Search</title>
</head>
<body>
    <form id="form1" runat="server">
        <main class="overflow-hidden">
            <!-- *************navbar -->
            <nav
                class="wrapper container-fluid navbar navbar-expand-lg navbar-light bg-light px-3">
                <a class="navbar-brand" href="../Home/home.aspx">
                    <img
                        src="./images/logo.png"
                        alt="Logo"
                        class="img-fluid"
                        style="max-width: 150px; height: auto" />
                </a>

                <button
                    class="navbar-toggler"
                    type="button"
                    data-bs-toggle="collapse"
                    data-bs-target="#navbarSupportedContent"
                    aria-controls="navbarSupportedContent"
                    aria-expanded="false"
                    aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <div
                    class="collapse navbar-collapse justify-content-between"
                    id="navbarSupportedContent">
                    <ul class="navbar-nav">
                        <li class="nav-item active">
                            <a
                                class="nav-link fw-bold color-blue"
                                href="../WorkPage/work.aspx"
                                style="font-size: 16px">HOW IT WORKS</a>
                        </li>
                        <li class="nav-item">
                            <a
                                class="nav-link fw-bold color-blue"
                                href="#"
                                style="font-size: 16px">CONTACT US</a>
                        </li>
                    </ul>
                    <button runat="server" class="btn btn-outline-primary color-blue resultBtns" onserverclick="logout" style="font-size: 14px; border-radius: 2px">Logout</button>
                </div>
            </nav>

            <!-- *************form section -->
            <div
                class="container-fluid py-3 pt-0 pe-0"
                style="background-color: rgb(231, 231, 231)">
                <div class="">
                    <div
                        class="row d-flex align-items-center justify-content-center ps-lg-5 ps-md-0 ps-lg-3 flex-row">
                        <!-- checkbox -->
                        <div class="col-lg-2 col-md-2 ps-lg-3 col-sm-6 ps-0 notMobile">
                            <label for="cause" class="color-blue fw-bold mb-3">Cause</label>
                            <div class="d-flex flex-wrap">
                                <div class="form-check checkBoxVal me-3">
                                    <input
                                        class="form-check-input"
                                        type="checkbox"
                                        value="volunteer"
                                        id="inlineCheckbox1"
                                        onclick="aaplyFilter()" />
                                    <label class="form-check-label" for="inlineCheckbox1">
                                        Volunteer</label>
                                </div>
                                <div class="form-check checkBoxVal me-3">
                                    <input
                                        class="form-check-input"
                                        type="checkbox"
                                        value="teach"
                                        id="teach"
                                        onclick="aaplyFilter()" />
                                    <label class="form-check-label" for="teach">Teach</label>
                                </div>
                                <div class="form-check checkBoxVal">
                                    <input
                                        class="form-check-input"
                                        type="checkbox"
                                        value="intern"
                                        id="intern1"
                                        onclick="aaplyFilter()" />
                                    <label class="form-check-label" for="intern1">Intern</label>
                                </div>
                            </div>
                        </div>

                        <!-- imput -->
                        <div class="col-lg-4 col-md-4 col-sm-6 text-end notMobile">
                            <label
                                for="searchCountry"
                                class="color-blue fw-bold text-start d-block">
                                Country</label>
                            <input
                                type="text"
                                class="form-control bg-white"
                                id="searchCountry"
                                onchange="aaplyFilter()"
                                placeholder="Search Country"
                                style="border-radius: 2px; border: 1px solid #8f8f8f" />
                        </div>

                        <!-- dropdown for activity -->
                        <div class="col-lg-4 col-md-4 col-sm-6 text-end notMobile">
                            <label
                                for="activitySelect"
                                class="color-blue fw-bold text-start d-block">
                                Activity</label>
                            <select
                                id="activitySelect"
                                class="form-select bg-white"
                                style="border-radius: 2px !important; border: 1px solid #8f8f8f !important;"
                                onchange="aaplyFilter()">
                                <option selected>Select Activity</option>
                                <option>Animal Conservation</option>
                                <option>Teach English</option>
                                <option>Medical Volunteering</option>
                            </select>
                        </div>

                        <!-- edit btn for mobile view -->
                        <div class="col row mt-3 editBtn">
                            <div class="col-7">
                                <p>
                                    Volunteer <span>in </span>Cambodia <span>for </span>Animal
                  Conversation
                                </p>
                            </div>
                            <div class="col-2">
                                <img src="./images/edit-icon.png" alt="Edit Icon" />
                            </div>
                            <div class="col-1">
                                <hr class="my-0" />
                            </div>
                            <div class="col temp"></div>
                        </div>

                        <!-- more filter btn -->
                        <div class="col col-lg-2 col-md-1 col-sm-6 text-end">
                            <label class="color-blue fw-bold d-block">&nbsp;</label>

                            <a href="#" class="text-decoration-none">
                                <button
                                    type="button"
                                    class="btn btn-outline-primary position-relative d-flex color-blue deskBtn btn-clicked"
                                    style="border-radius: 2px"
                                    data-bs-toggle="offcanvas"
                                    data-bs-target="#offcanvasTop"
                                    aria-controls="offcanvasTop">
                                    <span class="deskBtn">More filters</span>
                                    <span class="tabBtn">...</span>
                                    <span
                                        class="position-absolute top-0 start-100 translate-middle badge rounded-pill bgColor-blue btn-clicked filterVal">0
                                    </span>
                                </button>
                            </a>
                        </div>
                    </div>
                </div>
            </div>

            <!-- filter wrap for more filter -->
            <div
                class="offcanvas offcanvas-top fullViewCanvas search-panel"
                tabindex="-1"
                id="offcanvasTop"
                aria-labelledby="offcanvasTopLabel">
                <div class="offcanvas-header crossBtn text-center">
                    <button
                        type="button"
                        class="btn-close text-reset"
                        data-bs-dismiss="offcanvas"
                        aria-label="Close">
                    </button>
                </div>
                <div class="offcanvas-body pt-0">
                    <div class="container-fluid">
                        <div class="row mt-4">
                            <div class="col-lg-4 row border-end mb-5 me-0 pe-0">
                                <div class="col-12 col-lg-11 row gap1 mb-2 pe-0 me-0">
                                    <label class="col-6 color-blue">Start date (range)</label>
                                    <label
                                        class="col-6 pe-0 text-danger text-end resetBtnDate"
                                        style="cursor: pointer">
                                        Reset</label>
                                </div>
                                <div class="col">
                                    <select
                                        id="month_start"
                                        class="form-select shadow-sm pb-3 monthVal"
                                        onchange="aaplyFilter()">
                                        <option>month</option>
                                        <option value="jan">January</option>
                                        <option value="feb">February</option>
                                        <option value="march">March</option>
                                        <option value="apr">April</option>
                                        <option value="may">May</option>
                                        <option value="june">June</option>
                                        <option value="jul">July</option>
                                        <option value="aug">August</option>
                                        <option value="sept">September</option>
                                        <option value="oct">October</option>
                                        <option value="nov">November</option>
                                        <option value="dec">December</option>
                                    </select>
                                    <select
                                        id="month_end"
                                        class="form-select shadow-sm mt-2 pb-3 monthVal2"
                                        onchange="aaplyFilter()">
                                        <option>month</option>
                                        <option>January</option>
                                        <option>February</option>
                                        <option>March</option>
                                        <option>April</option>
                                        <option>May</option>
                                        <option>June</option>
                                        <option>July</option>
                                        <option>August</option>
                                        <option>September</option>
                                        <option>October</option>
                                        <option>November</option>
                                        <option>December</option>
                                    </select>
                                </div>

                                <div class="col-2 ps-0 ps-0 pe-0">
                                    <select
                                        id="day_start"
                                        class="form-select shadow-sm pb-3 dayVal"
                                        onchange="aaplyFilter()">
                                        <option>dd</option>
                                        <script>
                                            for (let i = 1; i <= 31; i++) {
                                                document.write(`<option>${i}</option>`);
                                            }
                                        </script>
                                    </select>
                                    <select
                                        id="day_end"
                                        class="form-select shadow-sm mt-2 pb-3 dayVal2"
                                        onchange="aaplyFilter()">
                                        <option>dd</option>
                                        <script>
                                            for (let i = 1; i <= 31; i++) {
                                                document.write(`<option>${i}</option>`);
                                            }
                                        </script>
                                    </select>
                                </div>

                                <div class="col">
                                    <select
                                        id="year_start"
                                        class="form-select shadow-sm pb-3 yearVal"
                                        onchange="aaplyFilter()">
                                        <option selected class="hidden-option">yyyy</option>
                                        <script>
                                            const currentYear = new Date().getFullYear();
                                            for (let i = currentYear; i >= 2000; i--) {
                                                document.write(`<option>${i}</option>`);
                                            }
                                        </script>
                                    </select>
                                    <select
                                        id="year-end"
                                        class="form-select shadow-sm mt-2 pb-3 align-self-center yearVal2"
                                        onchange="aaplyFilter()">
                                        <option selected class="hidden-option">yyyy</option>
                                        <script>
                                            for (let i = currentYear; i >= 2000; i--) {
                                                document.write(`<option>${i}</option>`);
                                            }
                                        </script>
                                    </select>
                                </div>

                                <div class="col-1">
                                    <span class="fw-bold">- </span>
                                </div>
                            </div>

                            <div class="col-lg-4 border-end mb-5">
                                <div class="col-12 row ms-0 mb-2">
                                    <label class="col-6 color-blue">Duration</label>
                                    <label
                                        class="col-6 text-danger text-end resetBtnRange"
                                        style="cursor: pointer">
                                        Reset</label>
                                </div>
                                <div class="container">
                                    <div style="margin-bottom: 10px">
                                        <span id="min_price">1</span>
                                        <span>week</span>
                                        <span>-</span>
                                        <span id="max_price">10</span>
                                        <span>weeks</span>
                                    </div>
                                    <div id="slider"></div>
                                </div>
                            </div>

                            <div class="col-lg-4">
                                <label class="col-12 mb-2 color-blue">Minimum Age</label>
                                <select
                                    id="min_age"
                                    class="form-select mt-2 pb-3 ageVal"
                                    onchange="aaplyFilter()">
                                    <!-- id="minAgeSelect" -->
                                    <option selected>--</option>
                                    <script>
                                        for (let i = 18; i <= 60; i++) {
                                            document.write(`<option value="${i}">${i}</option>`);
                                        }
                                    </script>
                                </select>
                            </div>
                        </div>

                        <div class="text-center mt-4">
                            <button
                                type="button"
                                class="btn text-white bgColor-blue color-blue btn-sm pe-3 ps-3 pt-2 pb-2 resultBtn">
                                See results
                            </button>
                        </div>
                    </div>
                </div>
            </div>

            <!-- ************* search-panel -->
            <div class="mt-3 mb-3 search-panel">
                <div class="sortBy row mx-md-2 mx-lg-5 px-md-2 mx-3">
                    <span class="col-3 col-md-6 ps-0">329 Results</span>
                    <div class="ddSoftBy col col-md-6 text-end">
                        <div class="dropdownSort example-container half">
                            <span class="sortBy">Sort&nbsp;by: </span>
                            <select id="type_select">
                                <option selected class="hidden-option">Relevancy</option>
                                <option value="AL">Medical Volunteer</option>
                                <option value="AK">Teach English & French</option>
                                <option value="AZ">Arizona</option>
                                <option value="AR">Suft School for Children</option>
                            </select>
                        </div>
                    </div>
                </div>
            </div>

            <!-- *************results -->
            <div
                class="container-fluid d-flex align-self-center justify-content-center flex-row">
                <div class="row ms-2 mx-md-1 mx-lg-5">
                    <!-- swiper 1 -->
                    <div
                        class="col-12 col-md-4 col-lg-4 ps-0"
                        style="margin-bottom: 1.5rem">
                        <div class="card border-0">
                            <div class="swiper mySwiper">
                                <a href="Javascript:updateURL(1)" class="swiper-wrapper">
                                    <div class="swiper-slide">
                                        <img src="./images/photo01.jpg" alt="ph1" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">VOLUNTEERING
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo02.jpg" alt="ph2" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">LOREM IPSUM
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo03.jpg" alt="ph3" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">DONOR SIT
                                            </h6>
                                        </div>
                                    </div>
                                </a>
                                <div class="swiper-button-next"></div>
                                <div class="swiper-button-prev"></div>
                            </div>
                            <div class="card-body ps-0">
                                <h6 class="card-text">Volunteer with Tigers</h6>
                                <img
                                    src="./images/volunteer-logo01.png"
                                    class="img-fluid rounded-circle main"
                                    style="width: 20px"
                                    alt="" />
                                <span class="color-blue">Love Volunteers</span>
                                <p>
                                    $215/week <span class="text-red">. </span>1-12 week duration
                                </p>
                            </div>
                        </div>
                    </div>
                    <br />

                    <!-- swiper 2 -->
                    <div
                        class="col-12 col-md-4 col-lg-4 ps-0"
                        style="margin-bottom: 1.5rem">
                        <div class="card border-0">
                            <div class="swiper mySwiper">
                                <a href="Javascript:updateURL(2)" class="swiper-wrapper">
                                    <div class="swiper-slide">
                                        <img src="./images/photo02.jpg" alt="ph1" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">LOREM IPSUM
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo01.jpg" alt="ph2" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">VOLUNTEERING
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo03.jpg" alt="ph3" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">DONOR SIT
                                            </h6>
                                        </div>
                                    </div>
                                </a>
                                <div class="swiper-button-next"></div>
                                <div class="swiper-button-prev"></div>
                            </div>
                            <div class="card-body ps-0">
                                <h6 class="card-text">Volunteer with Tigers</h6>
                                <img
                                    src="./images/volunteer-logo01.png"
                                    class="img-fluid rounded-circle main"
                                    style="width: 20px"
                                    alt="" />
                                <span class="color-blue">Love Volunteers</span>
                                <p>
                                    $215/week <span class="text-red">. </span>1-12 week duration
                                </p>
                            </div>
                        </div>
                    </div>
                    <br />

                    <!-- swiper 3 -->
                    <div
                        class="col-12 col-md-4 col-lg-4 ps-0"
                        style="margin-bottom: 1.5rem">
                        <div class="card border-0">
                            <div class="swiper mySwiper">
                                <a href="Javascript:updateURL(3)" class="swiper-wrapper">
                                    <div class="swiper-slide">
                                        <img src="./images/photo03.jpg" alt="ph1" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">DONOR SIT
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo02.jpg" alt="ph2" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">VOLUNTEERING
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo01.jpg" alt="ph3" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">MEDICAL VOLUNTEERING
                                            </h6>
                                        </div>
                                    </div>
                                </a>
                                <div class="swiper-button-next"></div>
                                <div class="swiper-button-prev"></div>
                            </div>
                            <div class="card-body ps-0">
                                <h6 class="card-text">Volunteer with Tigers</h6>
                                <img
                                    src="./images/volunteer-logo01.png"
                                    class="img-fluid rounded-circle main"
                                    style="width: 20px"
                                    alt="" />
                                <span class="color-blue">Love Volunteers</span>
                                <p>
                                    $215/week <span class="text-red">. </span>1-12 week duration
                                </p>
                            </div>
                        </div>
                    </div>
                    <br />

                    <!-- swiper 4 -->
                    <div
                        class="col-12 col-md-4 col-lg-4 ps-0"
                        style="margin-bottom: 1.5rem">
                        <div class="card border-0">
                            <div class="swiper mySwiper">
                                <a href="Javascript:updateURL(4)" class="swiper-wrapper">
                                    <div class="swiper-slide">
                                        <img src="./images/photo02.jpg" alt="ph1" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">LOREM IPSUM
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo01.jpg" alt="ph2" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">VOLUNTEERING
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo03.jpg" alt="ph3" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">DONOR SIT
                                            </h6>
                                        </div>
                                    </div>
                                </a>
                                <div class="swiper-button-next"></div>
                                <div class="swiper-button-prev"></div>
                            </div>
                            <div class="card-body ps-0">
                                <h6 class="card-text">Volunteer with Tigers</h6>
                                <img
                                    src="./images/volunteer-logo01.png"
                                    class="img-fluid rounded-circle main"
                                    style="width: 20px"
                                    alt="" />
                                <span class="color-blue">Love Volunteers</span>
                                <p>
                                    $215/week <span class="text-red">. </span>1-12 week duration
                                </p>
                            </div>
                        </div>
                    </div>
                    <br />


                    <div
                        class="col-12 col-md-4 col-lg-4 ps-0"
                        style="margin-bottom: 1.5rem">
                        <div class="card border-0">
                            <div class="swiper mySwiper">
                                <a href="Javascript:updateURL(5)" class="swiper-wrapper">
                                    <div class="swiper-slide">
                                        <img src="./images/photo02.jpg" alt="ph1" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">LOREM IPSUM
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo01.jpg" alt="ph2" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">VOLUNTEERING
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo03.jpg" alt="ph3" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">DONOR SIT
                                            </h6>
                                        </div>
                                    </div>
                                </a>
                                <div class="swiper-button-next"></div>
                                <div class="swiper-button-prev"></div>
                            </div>
                            <div class="card-body ps-0">
                                <h6 class="card-text">Volunteer with Tigers</h6>
                                <img
                                    src="./images/volunteer-logo01.png"
                                    class="img-fluid rounded-circle main"
                                    style="width: 20px"
                                    alt="" />
                                <span class="color-blue">Love Volunteers</span>
                                <p>
                                    $215/week <span class="text-red">. </span>1-12 week duration
                                </p>
                            </div>
                        </div>
                    </div>
                    <br />

                    <div
                        class="col-12 col-md-4 col-lg-4 ps-0"
                        style="margin-bottom: 1.5rem">
                        <div class="card border-0">
                            <div class="swiper mySwiper">
                                <a href="Javascript:updateURL(6)" class="swiper-wrapper">
                                    <div class="swiper-slide">
                                        <img src="./images/photo02.jpg" alt="ph1" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">LOREM IPSUM
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo01.jpg" alt="ph2" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">VOLUNTEERING
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo03.jpg" alt="ph3" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">DONOR SIT
                                            </h6>
                                        </div>
                                    </div>
                                </a>
                                <div class="swiper-button-next"></div>
                                <div class="swiper-button-prev"></div>
                            </div>
                            <div class="card-body ps-0">
                                <h6 class="card-text">Volunteer with Tigers</h6>
                                <img
                                    src="./images/volunteer-logo01.png"
                                    class="img-fluid rounded-circle main"
                                    style="width: 20px"
                                    alt="" />
                                <span class="color-blue">Love Volunteers</span>
                                <p>
                                    $215/week <span class="text-red">. </span>1-12 week duration
                                </p>
                            </div>
                        </div>
                    </div>
                    <br />

                    <div
                        class="col-12 col-md-4 col-lg-4 ps-0"
                        style="margin-bottom: 1.5rem">
                        <div class="card border-0">
                            <div class="swiper mySwiper">
                                <a href="Javascript:updateURL(7)" class="swiper-wrapper">
                                    <div class="swiper-slide">
                                        <img src="./images/photo02.jpg" alt="ph1" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">LOREM IPSUM
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo01.jpg" alt="ph2" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">VOLUNTEERING
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo03.jpg" alt="ph3" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">DONOR SIT
                                            </h6>
                                        </div>
                                    </div>
                                </a>
                                <div class="swiper-button-next"></div>
                                <div class="swiper-button-prev"></div>
                            </div>
                            <div class="card-body ps-0">
                                <h6 class="card-text">Volunteer with Tigers</h6>
                                <img
                                    src="./images/volunteer-logo01.png"
                                    class="img-fluid rounded-circle main"
                                    style="width: 20px"
                                    alt="" />
                                <span class="color-blue">Love Volunteers</span>
                                <p>
                                    $215/week <span class="text-red">. </span>1-12 week duration
                                </p>
                            </div>
                        </div>
                    </div>
                    <br />


                    <div
                        class="col-12 col-md-4 col-lg-4 ps-0"
                        style="margin-bottom: 1.5rem">
                        <div class="card border-0">
                            <div class="swiper mySwiper">
                                <a href="Javascript:updateURL(8)" class="swiper-wrapper">
                                    <div class="swiper-slide">
                                        <img src="./images/photo02.jpg" alt="ph1" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">LOREM IPSUM
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo01.jpg" alt="ph2" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">VOLUNTEERING
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo03.jpg" alt="ph3" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">DONOR SIT
                                            </h6>
                                        </div>
                                    </div>
                                </a>
                                <div class="swiper-button-next"></div>
                                <div class="swiper-button-prev"></div>
                            </div>
                            <div class="card-body ps-0">
                                <h6 class="card-text">Volunteer with Tigers</h6>
                                <img
                                    src="./images/volunteer-logo01.png"
                                    class="img-fluid rounded-circle main"
                                    style="width: 20px"
                                    alt="" />
                                <span class="color-blue">Love Volunteers</span>
                                <p>
                                    $215/week <span class="text-red">. </span>1-12 week duration
                                </p>
                            </div>
                        </div>
                    </div>
                    <br />

                    <div
                        class="col-12 col-md-4 col-lg-4 ps-0"
                        style="margin-bottom: 1.5rem">
                        <div class="card border-0">
                            <div class="swiper mySwiper">
                                <a href="Javascript:updateURL(9)" class="swiper-wrapper">
                                    <div class="swiper-slide">
                                        <img src="./images/photo02.jpg" alt="ph1" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">LOREM IPSUM
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo01.jpg" alt="ph2" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">VOLUNTEERING
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo03.jpg" alt="ph3" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">DONOR SIT
                                            </h6>
                                        </div>
                                    </div>
                                </a>
                                <div class="swiper-button-next"></div>
                                <div class="swiper-button-prev"></div>
                            </div>
                            <div class="card-body ps-0">
                                <h6 class="card-text">Volunteer with Tigers</h6>
                                <img
                                    src="./images/volunteer-logo01.png"
                                    class="img-fluid rounded-circle main"
                                    style="width: 20px"
                                    alt="" />
                                <span class="color-blue">Love Volunteers</span>
                                <p>
                                    $215/week <span class="text-red">. </span>1-12 week duration
                                </p>
                            </div>
                        </div>
                    </div>
                    <br />


                    <div
                        class="col-12 col-md-4 col-lg-4 ps-0"
                        style="margin-bottom: 1.5rem">
                        <div class="card border-0">
                            <div class="swiper mySwiper">
                                <a href="Javascript:updateURL(10)" class="swiper-wrapper">
                                    <div class="swiper-slide">
                                        <img src="./images/photo02.jpg" alt="ph1" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">LOREM IPSUM
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo01.jpg" alt="ph2" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">VOLUNTEERING
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo03.jpg" alt="ph3" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">DONOR SIT
                                            </h6>
                                        </div>
                                    </div>
                                </a>
                                <div class="swiper-button-next"></div>
                                <div class="swiper-button-prev"></div>
                            </div>
                            <div class="card-body ps-0">
                                <h6 class="card-text">Volunteer with Tigers</h6>
                                <img
                                    src="./images/volunteer-logo01.png"
                                    class="img-fluid rounded-circle main"
                                    style="width: 20px"
                                    alt="" />
                                <span class="color-blue">Love Volunteers</span>
                                <p>
                                    $215/week <span class="text-red">. </span>1-12 week duration
                                </p>
                            </div>
                        </div>
                    </div>
                    <br />


                    <div
                        class="col-12 col-md-4 col-lg-4 ps-0"
                        style="margin-bottom: 1.5rem">
                        <div class="card border-0">
                            <div class="swiper mySwiper">
                                <a href="Javascript:updateURL(11)" class="swiper-wrapper">
                                    <div class="swiper-slide">
                                        <img src="./images/photo02.jpg" alt="ph1" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">LOREM IPSUM
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo01.jpg" alt="ph2" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">VOLUNTEERING
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo03.jpg" alt="ph3" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">DONOR SIT
                                            </h6>
                                        </div>
                                    </div>
                                </a>
                                <div class="swiper-button-next"></div>
                                <div class="swiper-button-prev"></div>
                            </div>
                            <div class="card-body ps-0">
                                <h6 class="card-text">Volunteer with Tigers</h6>
                                <img
                                    src="./images/volunteer-logo01.png"
                                    class="img-fluid rounded-circle main"
                                    style="width: 20px"
                                    alt="" />
                                <span class="color-blue">Love Volunteers</span>
                                <p>
                                    $215/week <span class="text-red">. </span>1-12 week duration
                                </p>
                            </div>
                        </div>
                    </div>
                    <br />


                    <div
                        class="col-12 col-md-4 col-lg-4 ps-0"
                        style="margin-bottom: 1.5rem">
                        <div class="card border-0">
                            <div class="swiper mySwiper">
                                <a href="Javascript:updateURL(12)" class="swiper-wrapper">
                                    <div class="swiper-slide">
                                        <img src="./images/photo02.jpg" alt="ph1" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">LOREM IPSUM
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo01.jpg" alt="ph2" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">VOLUNTEERING
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo03.jpg" alt="ph3" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">DONOR SIT
                                            </h6>
                                        </div>
                                    </div>
                                </a>
                                <div class="swiper-button-next"></div>
                                <div class="swiper-button-prev"></div>
                            </div>
                            <div class="card-body ps-0">
                                <h6 class="card-text">Volunteer with Tigers</h6>
                                <img
                                    src="./images/volunteer-logo01.png"
                                    class="img-fluid rounded-circle main"
                                    style="width: 20px"
                                    alt="" />
                                <span class="color-blue">Love Volunteers</span>
                                <p>
                                    $215/week <span class="text-red">. </span>1-12 week duration
                                </p>
                            </div>
                        </div>
                    </div>
                    <br />


                    <div
                        class="col-12 col-md-4 col-lg-4 ps-0"
                        style="margin-bottom: 1.5rem">
                        <div class="card border-0">
                            <div class="swiper mySwiper">
                                <a href="Javascript:updateURL(13)" class="swiper-wrapper">
                                    <div class="swiper-slide">
                                        <img src="./images/photo02.jpg" alt="ph1" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">LOREM IPSUM
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo01.jpg" alt="ph2" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">VOLUNTEERING
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo03.jpg" alt="ph3" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">DONOR SIT
                                            </h6>
                                        </div>
                                    </div>
                                </a>
                                <div class="swiper-button-next"></div>
                                <div class="swiper-button-prev"></div>
                            </div>
                            <div class="card-body ps-0">
                                <h6 class="card-text">Volunteer with Tigers</h6>
                                <img
                                    src="./images/volunteer-logo01.png"
                                    class="img-fluid rounded-circle main"
                                    style="width: 20px"
                                    alt="" />
                                <span class="color-blue">Love Volunteers</span>
                                <p>
                                    $215/week <span class="text-red">. </span>1-12 week duration
                                </p>
                            </div>
                        </div>
                    </div>
                    <br />


                    <div
                        class="col-12 col-md-4 col-lg-4 ps-0"
                        style="margin-bottom: 1.5rem">
                        <div class="card border-0">
                            <div class="swiper mySwiper">
                                <a href="Javascript:updateURL(14)" class="swiper-wrapper">
                                    <div class="swiper-slide">
                                        <img src="./images/photo02.jpg" alt="ph1" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">LOREM IPSUM
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo01.jpg" alt="ph2" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">VOLUNTEERING
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo03.jpg" alt="ph3" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">DONOR SIT
                                            </h6>
                                        </div>
                                    </div>
                                </a>
                                <div class="swiper-button-next"></div>
                                <div class="swiper-button-prev"></div>
                            </div>
                            <div class="card-body ps-0">
                                <h6 class="card-text">Volunteer with Tigers</h6>
                                <img
                                    src="./images/volunteer-logo01.png"
                                    class="img-fluid rounded-circle main"
                                    style="width: 20px"
                                    alt="" />
                                <span class="color-blue">Love Volunteers</span>
                                <p>
                                    $215/week <span class="text-red">. </span>1-12 week duration
                                </p>
                            </div>
                        </div>
                    </div>
                    <br />


                    <div
                        class="col-12 col-sm-4 col-lg-4 ps-0"
                        style="margin-bottom: 1.5rem">
                        <div class="card border-0">
                            <div class="swiper mySwiper">
                                <a href="Javascript:updateURL(15)" class="swiper-wrapper">
                                    <div class="swiper-slide">
                                        <img src="./images/photo02.jpg" alt="ph1" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">LOREM IPSUM
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo01.jpg" alt="ph2" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">VOLUNTEERING
                                            </h6>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <img src="./images/photo03.jpg" alt="ph3" />
                                        <div class="card-img-overlay" style="right: 60%">
                                            <h6
                                                class="card-title bg-white px-2 py-1 rounded-2 fs-5"
                                                style="color: #eb374e; display: inline-block; font-size: 14px !important;">DONOR SIT
                                            </h6>
                                        </div>
                                    </div>
                                </a>
                                <div class="swiper-button-next"></div>
                                <div class="swiper-button-prev"></div>
                            </div>
                            <div class="card-body ps-0">
                                <h6 class="card-text">Volunteer with Tigers</h6>
                                <img
                                    src="./images/volunteer-logo01.png"
                                    class="img-fluid rounded-circle main"
                                    style="width: 20px"
                                    alt="" />
                                <span class="color-blue">Love Volunteers</span>
                                <p>
                                    $215/week <span class="text-red">. </span>1-12 week duration
                                </p>
                            </div>
                        </div>
                    </div>
                    <br />
                </div>
            </div>

            <!-- **************pagination -->
            <nav aria-label="Page navigation example">
                <ul class="pagination justify-content-center">
                    <li class="page-item">
                        <a class="page-link" href="#" aria-label="Previous">
                            <span aria-hidden="true">&laquo;</span>
                            <span class="sr-only">Previous</span>
                        </a>
                    </li>
                    <li class="page-item"><a class="page-link" href="#">1</a></li>
                    <li class="page-item"><a class="page-link" href="#">2</a></li>
                    <li class="page-item"><a class="page-link" href="#">3</a></li>
                    <li class="page-item">
                        <a class="page-link" href="#" aria-label="Next">
                            <span aria-hidden="true">&raquo;</span>
                            <span class="sr-only">Next</span>
                        </a>
                    </li>
                </ul>
            </nav>

            <!-- **************pagination -->
            <footer
                class="d-flex flex-wrap justify-content-between align-items-center py-3 mt-4 border-top bg-secondary">
                <img
                    src="./images/logo_1.png"
                    alt="Logo"
                    class="img-fluid"
                    style="max-width: 150px; height: auto" />

                <a
                    href="/"
                    class="col-md-4 d-flex align-items-center justify-content-center mb-3 mb-md-0 me-md-auto link-dark text-decoration-none">
                    <svg class="bi me-2" width="40" height="32">
                        <use xlink:href="#bootstrap"></use>
                    </svg>
                </a>

                <ul class="nav col-md-4 justify-content-end">
                    <li class="nav-item">
                        <a href="#" class="nav-link px-2 text-white BtnH">FAQs</a>
                    </li>
                    <li class="nav-item">
                        <a href="#" class="nav-link px-2 text-white BtnH">CONTACT US</a>
                    </li>
                </ul>
            </footer>
        </main>
    </form>

    <script>
        function updateURL(projectId) {
            window.location.href = `../SearchPage/Search.aspx?projectid=` + projectId;
        }
      </script>

    <script>
        function aaplyFilter1() {
            console.log("hello");
        }
    </script>

    <script>
        let autoTags = [
            "India",
            "Austrelia",
            "Bubai",
            "America",
            "China",
            "Russia",
            "Brazil",
            "Canada",
            "Oman",
        ];
        $("#searchCountry").autocomplete({
            source: autoTags,
        });
    </script>

    <!-- swiper -->
    <script src="https://cdn.jsdelivr.net/npm/swiper@11/swiper-bundle.min.js"></script>
    <script>
        var swiper = new Swiper(".mySwiper", {
            responsive: {
                0: {
                    items: 1,
                },
                2500: {
                    items: 1,
                },
            },
            navigation: {
                nextEl: ".swiper-button-next",
                prevEl: ".swiper-button-prev",
            },
        });
    </script>

    <!-- nouislider -->
    <script src="./js/nouislider.min.js"></script>
    <script></script>

    <!-- swiper -->
    <!-- <script src="https://code.jquery.com/jquery-3.6.0.js"></script> -->
    <script src="https://code.jquery.com/ui/1.13.1/jquery-ui.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.min.js"></script>

    <script>
        $(function () {
            $(
                "#activitySelect, #month_start, #month_end, #day_start, #day_end,#year_start, #year-end"
            ).dropkick({
                mobile: true,
            });
            $("#min_age").dropkick({
                mobile: true,
            });
        });
    </script>
    <script src="script.js"></script>
</body>
</html>
