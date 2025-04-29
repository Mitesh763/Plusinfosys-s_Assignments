<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="work.aspx.cs" Inherits="VolunteerOverseas.WorkPage.work" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />

    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script
        src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"
        type="text/javascript"></script>

    <!-- dropkick -->

    <link rel="stylesheet" href="work.css" />
    <title>Volunteer Oversees - Work</title>
</head>

<body>
    <form id="form1" runat="server">
        <main>
            <div class=" m-0 ps-0">
                <div class="img-bg img-fluid w-100 homeImg">

                    <!--*********navbar  -->
                    <nav class="bg-transparent border-bottom navbar navbar-expand-lg navbar-light pb-0 px-4 small-header wrapper">
                        <a class="navbar-brand" href="../Home/home.aspx">
                            <img src="./images/logo_1.png" alt="Logo" class="img-fluid" style="max-width: 150px; height: auto" />
                        </a>
                        <button class="navbar-toggler" type="button" data-bs-toggle="collapse"
                            data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false"
                            aria-label="Toggle navigation">
                            <span class="navbar-toggler-icon"></span>
                        </button>
                        <div class="collapse navbar-collapse justify-content-between" id="navbarSupportedContent">
                            <ul class="navbar-nav">
                                <li class="nav-item active">
                                    <a class="nav-link text-white border-bottom f-onesix btnA" href="#" style="padding-bottom: 16%;">HOW IT
                  WORKS</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link text-white f-onesix btnA" href="#">CONTACT US</a>
                                </li>
                            </ul>

                            <button runat="server" type="button" onserverclick="logout" class="btn btn-outline-primary text-white border-white f-onefour">
                                Logout
                            </button>
                        </div>
                    </nav>
                    <br />

                    <!-- ********** start content -->
                    <div class="row d-flex m-xl-5 p-xl-5 m-lg-4">
                        <div class="col-lg-7 col-md-7 col-sm-12 d-flex justify-content-center  flex-column ">
                            <h2 class="text-md-start text-lg-start text-center f-foureight ms-md-5 ms-lg-4  " style="font-weight: 600;">Thinking Volunteer Overseas!
                            </h2>
                            <p
                                class="text-md-start text-lg-start text-center d-flex flex-wrap align-items-center ms-md-3 ps-md-4 px-3 color-blue f-threethreee ps-lg-2">
                                Volunteers, interns, and ESL teachers are solving problems and
              making a real difference abroad. Finding the perfect program you
              can trust shouldn't be a problem.
                            </p>
                        </div>
                        <div class="col-lg-5 col-md-5 col-sm-12 d-flex align-items-center justify-content-center">
                            <div class="border rounded-3 g-3 bg-red watchBtn" class="btn btn-primary" data-bs-toggle="modal"
                                data-bs-target="#exampleModal" style="border-radius: 16px !important;">
                                <img src="./images/play-ico.svg" class="img-fluid mx-3 me-4 mb-3 ms-3 mt-3 mt-lg-0" style="width: 11%;"
                                    alt="" />
                                <span class="f-fourthree" style="font-weight: 600;" class="mt-2 ">Watch the tour</span>
                            </div>
                        </div>
                    </div>

                    <!-- ********** Video btn -->
                    <div class="modal-dialog modal-dialog-centered">
                        <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel"
                            aria-hidden="true">
                            <div class="modal-dialog modal-lg">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h5 class="modal-title" id="exampleModalLabel">Watch the Tour Video - Volunteer Overseas
                                        </h5>
                                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                                    </div>
                                    <div class="modal-body">
                                        <video controls autoplay width="100%">
                                            <source src="./images/video.mp4" type="" />
                                        </video>
                                    </div>
                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">
                                            Close
                                        </button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <!--  ************ body Content -->
                <div class="content1">
                    <h2 class="text-lg-center text-center color-blue my-5 f-fivefour offset-md-2 offset-lg-0">How Volunteer Overseas Works
                    </h2>

                    <!-- ***** d1 -->
                    <div class="description1 row align-items-start position-relative">
                        <img src="./images/works-thumb01-iphone.png" class="col-lg-5 position-absolute end-0 mobileImg" alt="" />
                        <div class="col-lg-7 row ms-md-2 d-flex align-items-start">
                            <div class="col-lg-2 offset-lg-1  offset-1 col-md-1 col-2 ps ps-md-4 ">
                                <span class="col-12 fw-bold bg-red rounded-circle text-white number-content f-exLarge">1</span>
                                <div class="col-12 line1">
                                    <img src="./images/line1.png" class="line1 left-0 position-relative" alt="" />
                                </div>
                            </div>
                            <div class="col-lg-8  col-md-6 col-8 d-flex align-self-center offset-lg-0  offset-md-1 mobileCSS">
                                <span class="text-center color-red fw-bold f-threesix ">Find Your Perfect Project
                                </span>
                            </div>
                            <br />
                            <div
                                class="col-lg-8 col-md-5 offset-xl-3 offset-md-3 offset-lg-4   m-topC m-topC-m mb-4 position-relative  d-flex align-items-center justify-content-center align-items-md-start justify-content-md-start text-md-start text-center">
                                <span class="word-break color-gray">Research and compare the best projects abroad based on what
                matters to you:</span>
                            </div>
                            <div class="col-lg-12 row offset-xl-3 offset-lg-4 offset-md-3 offset-2">
                                <div class="col-lg-3 col-md-2 col-2 ps-0">
                                    <span class="badge color-blue bg-transparent ps-0 f-twotwo">Location</span>
                                </div>
                                <div class="col-md-7 col-8 f-twotwo color-gray">
                                    Where's your dream destination?
                                </div>
                            </div>
                            <div class="col-lg-12 row offset-xl-3 offset-lg-4 offset-md-3 offset-2">
                                <div class="col-lg-3 col-md-2 col-2 ps-0">
                                    <span class="badge color-blue bg-transparent ps-0 f-twotwo">Activity</span>
                                </div>
                                <div class="col-md-7 col-7 f-twotwo color-gray">
                                    What do you see yourself doing?
                                </div>
                            </div>
                            <div class="col-lg-12 row offset-xl-3 offset-lg-4 offset-md-3 offset-2">
                                <div class="col-lg-3 col-md-2 col-2 ps-0 ">
                                    <span class="badge color-blue bg-transparent ps-0 f-twotwo">Duration</span>
                                </div>
                                <div class="col-md-7 col-7 f-twotwo color-gray">How much time do you have?</div>
                            </div>
                            <div class="col-lg-12 row offset-xl-3 offset-lg-4 offset-md-3 offset-2">
                                <div class="col-lg-3 col-md-2 col-2 ps-0 ">
                                    <span class="badge color-blue bg-transparent ps-0 f-twotwo">Start Dates</span>
                                </div>
                                <div class="col-md-7 col-7 f-twotwo color-gray">
                                    Fixed and flexible start dates (varies by program)
                                </div>
                            </div>
                        </div>
                        <img src="./images/works-thumb01.png" class="col-lg-5 position-absolute end-0 deskImg" alt="" />
                        <img src="./images/works-thumb01-ipad.png" class="col-lg-5 position-absolute end-0 tabImg" alt="" />

                    </div>

                    <!-- ***** d2 -->
                    <div class="description2 container row position-relative">
                        <div
                            class="col-lg-5 col-md-5 col-5 position-absolute start-0 deskImg2 d-flex align-items-center justify-content-center">
                            <img src="./images/works-thumb02.png" class="img-fluid d-content" />
                        </div>

                        <div class="col-lg-9 col-md-9 col-12 row offset-lg-4 offset-md-5 d-flex align-items-start">
                            <div class="col-lg-2 col-md-2 col-2">
                                <span class="col-12 fw-bold bg-red rounded-circle text-white number-content f-exLarge">2</span>
                                <div class="col-12 line2">
                                    <img src="./images/line2.png" class="left-0 position-relative" alt="" />
                                </div>
                            </div>
                            <div
                                class="col-lg-9 col-md-9 col-10 d-flex align-self-center align-items-center ms-lg-3 ps-4 ms-md-4 mobileCSS">
                                <span class="text-center color-red fw-bold f-threesix">Apply Now
                                </span>
                            </div>
                            <br />
                            <div class="col-lg-8 col-md-9 offset-xl-2 offset-lg-2 offset-md-3 mb-4 m-topC word-break">
                                <span class="ps-lg-3 color-gray">Follow our easy and secure application process:</span>
                            </div>
                            <div class="col-md-12 row offset-lg-2 offset-md-3 mb-2 ps-lg-3">
                                <div class="col-md-1 col-1 pe-lg-0 pe-md-2">
                                    <span class="badge text-white py-1 px-2 text-center rounded-circle f-twotwo bg-blue-round">1</span>
                                </div>
                                <div class="col-md-7 col-9 d-flex align-self-center ps-lg-0 ps-md-3 f-twotwo color-gray">
                                    Fill out your trip preferences
                                </div>
                            </div>
                            <div class="col-md-12 row offset-lg-2 offset-md-3 mb-2 ps-lg-3">
                                <div class="col-md-1 col-1 pe-lg-0 pe-md-2">
                                    <span class="badge text-white py-1 px-2 text-center rounded-circle f-twotwo bg-blue-round">2</span>
                                </div>
                                <div class="col-md-7 col-9 d-flex align-self-center ps-lg-0 ps-md-3 f-twotwo color-gray">
                                    Tell your program why you are a good fit
                                </div>
                            </div>
                            <div class="col-md-12 row offset-lg-2 offset-md-3 mb-2 ps-lg-3 mb-3">
                                <div class="col-md-1 col-1 pe-lg-0 pe-md-2">
                                    <span class="badge text-white py-1 px-2 text-center rounded-circle f-twotwo bg-blue-round">3</span>
                                </div>
                                <div class="col-md-7 col-9 d-flex align-self-center ps-lg-0 ps-md-3 f-twotwo color-gray">
                                    Reserve your spot with a small deposit*
                                </div>
                            </div>
                            <div class="col-lg-8 col-md-8 offset-xl-2 offset-lg-2 offset-md-3 mb-4 mt-lg-1
              "
                                style="background-color: #e3e3e375;">
                                <span class="word-break"><i class="fs-oneeight color-gray">* This deposit is generally a small portion of
                  the total
                  project fee. Your deposit secures your spot with the project
                  and shows that you are a serious applicant. This deposit is
                  fully refundable is you are accepte by the program.
                                </i></span>
                            </div>
                        </div>
                    </div>

                    <!-- ***** d3 -->
                    <div class="description3 row align-items-start position-relative">
                        <div class="col-md-8 row offset-lg-1  d-flex align-items-start">
                            <div class="col-lg-2 col-md-1 col-1 offset-md-1 offset-1 ps ps-md-4">
                                <span class="col-12 fw-bold bg-red rounded-circle  text-white number-content f-exLarge">3</span>
                                <div class="col-12 line3">
                                    <img src="./images/line3.png" class="left-0 position-relative" alt="" />
                                </div>
                            </div>
                            <div class="col-lg-8  col-md-8 col-9 d-flex align-self-center offset-lg-0 offset-md-2 offset-1 mobileCSS1">
                                <span class="text-center color-red fw-bold f-threesix">Wait to Hear Great News
                                </span>
                            </div>
                            <br />
                            <div
                                class="col-lg-8 col-md-8 col-11 offset-xl-3 offset-md-1 offset-lg-3 offset-md-4 offset-1 m-topC mb-4 d-flex align-items-center align-items-md-start text-center text-md-start flex-column">
                                <span class="word-break color-gray">After you submit your application, you will hear from your
                program within 3-7 business days.</span>
                                <span class="word-break color-gray">Applying through Volunteer Overseas automatically qualifies
                you to:</span>
                            </div>
                            <div class="col-lg-12 col-12 row offset-xl-3 offset-lg-4 offset-md-4 offset-md-2 offset-1">
                                <div class="col-1 ps-lg-0 ps-md-3">
                                    <span class="badge text-white py-1 px-2 text-center rounded-circle f-twotwo bg-blue-round">$</span>
                                </div>
                                <div class="col-md-9 col-10 f-twotwo ps-lg-0 ps-md-3 color-gray">
                                    Enter to win a scholarship from Volunteer Forever (up to
                $1,000)
                                </div>
                            </div>
                            <div class="col-lg-12 col-12 row offset-xl-3 offset-lg-4 offset-md-4 offset-md-2 offset-1">
                                <div class="col-lg-1 col-md-1 col-1 ps-lg-0 ps-md-3">
                                    <span class="badge text-white py-1 px-2 text-center rounded-circle f-twotwo bg-blue-round">$</span>
                                </div>
                                <div class="col-lg-8 col-md-9 col-10 f-twotwo ps-lg-0 ps-md-3 color-gray">
                                    Raise funds for your trip on Volunteer Forever's no-fee
                crowdfunding platform
                                </div>
                            </div>
                            <div class="ol-lg-8 col-md-8  offset-xl-3 offset-md-1 offset-lg-4 offset-md-4 mt-4">
                                <p class="color-blue fs-oneeight text-center text-md-start" style="font-weight: 600;">
                                    Talk about great
                news!
                                </p>
                            </div>
                        </div>
                        <img src="./images/works-thumb03.png" class="col-md-4 position-absolute end-0 deskImg3" alt="" />
                        <img src="./images/works-thumb03-ipad.png" class="col-md-4 position-absolute end-0 tabImg3" alt="" />
                        <br />
                    </div>

                    <!-- ***** d4 -->
                    <div class="description4 container row position-relative">
                        <div class="col-lg-5 col-md-5 col-5 position-absolute start-0 img4">
                            <img src="./images/works-thumb04.png" class="img-fluid d-content" />
                        </div>

                        <div class="col-lg-9 col-md-9 col-12 row offset-lg-4 offset-md-5 d-flex align-items-start">
                            <div class="col-lg-2 col-md-2 col-2">
                                <span class="col-12 fw-bold bg-red rounded-circle text-white number-content f-exLarge">4</span>
                                <div class="col-12 line4"></div>
                            </div>
                            <div
                                class="col-lg-9 col-md-9 col-10 d-flex align-self-center align-items-center ms-lg-3 ms-md-4 ps-4 mobileCSS1">
                                <span class="text-center color-red fw-bold f-threesix">Finalize your trip
                                </span>
                            </div>
                            <br />
                            <div class="col-lg-8 col-md-10 offset-lg-2 offset-md-2 mb-4 m-topC ps-lg-4 ps-md-5">
                                <span class="word-break color-gray">After you've been accepted, your program will help you with the not so little details:</span>
                            </div>
                            <div class="col-lg-12 col-md-12 row offset-lg-2 offset-md-3 mb-2  ps-lg-4">
                                <div class="col-lg-1 col-md-1 col-2 pe-lg-0 pe-md-2">
                                    <img src="./images/check.png" class="checkImg" alt="" />
                                </div>
                                <div class="col-lg-9 col-md-7 col-10 ps -lg-0 ps-md-3 f-twotwo d-flex align-self-center color-gray">
                                    The remainder of your program fee
                                </div>
                            </div>
                            <div class="col-lg-12 col-md-12 row offset-lg-2 offset-md-3 mb-2  ps-lg-4">
                                <div class="col-lg-1 col-md-1 col-2 pe-lg-0 pe-md-2">
                                    <img src="./images/check.png" class="checkImg" alt="" />
                                </div>
                                <div class="col-lg-9 col-md-7 col-10 ps -lg-0 ps-md-3 f-twotwo d-flex align-self-center color-gray">
                                    Final travel arrangement
                                </div>
                            </div>
                            <div class="col-lg-12 col-md-12 row offset-lg-2 offset-md-3 mb-2  ps-lg-4">
                                <div class="col-lg-1 col-md-1 col-2 pe-lg-0 pe-md-2">
                                    <img src="./images/check.png" class="checkImg" alt="" />
                                </div>
                                <div class="col-lg-9 col-md-7 col-10 ps -lg-0 ps-md-3 f-twotwo d-flex align-self-center color-gray">
                                    Your itinerary and work schedule
                                </div>
                            </div>
                            <div class="col-lg-12 col-md-12 row offset-lg-2 offset-md-3 mb-2  ps-lg-4">
                                <div class="col-lg-1 col-md-1 col-2 pe-lg-0 pe-md-2">
                                    <img src="./images/check.png" class="checkImg" alt="" />
                                </div>
                                <div class="col-lg-9 col-md-7 col-10 ps -lg-0 ps-md-3 f-twotwo d-flex align-self-center color-gray">
                                    Your medical, dietary or other personal needs
                                </div>
                            </div>
                            <div class="col-lg-12 col-md-12 row offset-lg-2 offset-md-3 mb-2 ps-lg-4 mb-4">
                                <div class="col-lg-1 col-md-1 col-2 pe-lg-0 pe-md-2">
                                    <img src="./images/check.png" class="checkImg" alt="" />
                                </div>
                                <div class="col-lg-9 col-md-7 col-10 ps -lg-0 ps-md-3 f-twotwo d-flex align-self-center color-gray">
                                    And to...
                                </div>
                            </div>
                            <div class="col-lg-8 col-md-12 col offset-lg-2 offset-md-2 mb-4 ps-lg-4 ps-md-5">
                                <p class="word-break color-blue fs-oneeight text-center text-md-start" style="font-weight: 600;">
                                    MAKE A DIFFERENCE VOLUNTEER OVERSEAS!
                                </p>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- **** below btn -->
                <div class="text-center my-5">
                    <a class="py-2 px-4 text-decoration-none text-white bg-red journeyBtn f-threesix py-4 px-5line-none btnA">Begin
          your journey</a>
                </div>
            </div>

            <!-- ***** footer -->
            <footer
                class="d-flex flex-wrap justify-content-between align-items-center py-3 px-2 mt-4 me-3 border-top bg-secondary">
                <img src="./images/logo_1.png" alt="Logo" class="img-fluid" style="max-width: 150px; height: auto" />
                <svg class="bi me-2" width="40" height="32">
                    <use xlink:href="#bootstrap"></use>
                </svg>
                </a>

      <ul class="nav col-md-4 justify-content-end">
          <li class="nav-item">
              <a href="#" class="nav-link px-2 text-white btnA">FAQs</a>
          </li>
          <li class="nav-item">
              <a href="#" class="nav-link px-2 text-white btnA">CONTACT US</a>
          </li>
      </ul>
            </footer>
        </main>
    </form>

    <script>
        $(window).scroll(function () {
            if ($(window).scrollTop() > 0) {
                $(".wrapper").addClass("small-header");
            } else {
                $(".wrapper").removeClass("small-header");
            }
        });
    </script>
</body>
</html>
