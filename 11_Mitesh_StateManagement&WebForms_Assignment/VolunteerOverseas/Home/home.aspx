<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="VolunteerOverseas.Home.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <script src="https://code.jquery.com/jquery-1.11.0.min.js"></script>

    <script src="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/owl.carousel.min.js"></script>

    <link
        rel="stylesheet"
        href="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/assets/owl.carousel.min.css" />
    <link
        rel="stylesheet"
        href="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/assets/owl.theme.default.min.css" />

    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>

    <link
        rel="stylesheet"
        href="https://code.jquery.com/ui/1.14.1/themes/base/jquery-ui.css" />
    <script src="https://code.jquery.com/jquery-3.6.0.js"></script>
    <script src="https://code.jquery.com/ui/1.13.1/jquery-ui.js"></script>

    <script src="./js/owl.carousel.js"></script>

    <!--dropkick  -->
    <link rel="stylesheet" href="./css/dropkick.css" />
    <script src="./js/dropkick.js"></script>
    <!-- <script src="dropkick.js"></script> -->


    <link rel="stylesheet" href="home.style.css" />

    <title>Welcome - Volunteer Oversees</title>
</head>
<body runat="server">

    <main class="mainB">
        <form id="form1" runat="server">
            <div class="container">
                <div class="introduction">
                    <!-- navbar ******* -->
                    <nav class="navbar wrapper">
                        <img class="mainLogo" src="Doc/images/logo_1.png" alt="" />
                        <div class="two_pages" runat="server">
                            <img class="humburgor" src="Doc/images/menu.svg" alt="" />
                            <img
                                class="crossMenu displayNone"
                                src="../Doc/images/cross.png"
                                alt="" />
                            <div class="pages">
                                <ul>
                                    <li>
                                        <a href="../WorkPage/work.aspx" style="color: white">HOW IT WORKS</a>
                                    </li>
                                    <li>
                                        <a href="#" style="color: white">CONTACT US</a>
                                    </li>
                                </ul>
                            </div>
                            <button runat="server" class="loginBtn" onserverclick="logout" style="cursor: pointer">Logout</button>

                        </div>
                    </nav>

                    <!-- **** introduction part -->
                    <div class="introDiscription">
                        <h2>Discover Yourself, Discover the World</h2>
                        <p>
                            Apply to your perfect volunteer, intern, or teach abroad program.
                        </p>
                        <div class="dropdown">
                            <table>
                                <tr>
                                    <th>
                                        <h2>Type</h2>
                                    </th>
                                    <th>
                                        <h2>Location</h2>
                                    </th>
                                    <th>
                                        <h2>Activity</h2>
                                    </th>
                                    <th></th>
                                </tr>
                                <tr>
                                    <td>
                                        <select id="type_select">
                                            <option disabled selected class="hidden-option">Volunteer Abroad
                                            </option>
                                            <option value="AL">Alabama</option>
                                            <option value="AK">Alaska</option>
                                            <option value="AZ">Arizona</option>
                                            <option value="AR">Arkansas</option>
                                        </select>
                                    </td>
                                    <td>
                                        <input
                                            type="text"
                                            id="location_input"
                                            placeholder="Anywhere" />
                                    </td>
                                    <td>
                                        <select id="activity_select">
                                            <option disabled selected class="hidden-option">Anything
                                            </option>
                                            <option value="CA">California</option>
                                            <option value="CO">Colorado</option>
                                            <option value="CT">Connecticut</option>
                                            <option value="DE">Delaware</option>
                                        </select>
                                    </td>
                                    <td>
                                        <button>
                                            <a
                                                href="../SearchPage/Search.aspx"
                                                style="color: white !important">Search</a>
                                        </button>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
            </div>

            <!--***** body content -->
            <div class="discriptionSession" style="position: sticky">
                <!-- carousel-1 ******** -->
                <div class="tendingPart">
                    <h2>Trending Projects</h2>
                    <div
                        class="owl-carousel owl-theme slider12"
                        style="position: relative">
                        <a href="Javascript:updateURL(1)">
                            <div
                                class="item item_desc item1_desc"
                                style="background-image: url('Doc/images/bg.png'),
                  url('Doc/images/thumb01.jpg'); background-repeat: no-repeat; background-size: cover;">
                                <div class="item_descs">
                                    <h4>Costa Rica</h4>
                                    <h2>MEDICAL SUPPORT IN QAPOS</h2>
                                    <p class="para1">Global Volunteering International</p>
                                    <p class="para2">12 people researching this project</p>
                                </div>
                            </div>
                        </a>
                        <a href="Javascript:updateURL(2)">
                            <div
                                class="item item_desc item1_desc"
                                style="background-image: url('Doc/images/bg.png'),
                  url('Doc/images/thumb02.jpg'); background-repeat: no-repeat; background-size: cover; background-attachment: local;">
                                <div class="item_descs">
                                    <h4>Peru</h4>
                                    <h2>VOLUNTEERING</h2>
                                    <p class="para1">Global Volunteering International</p>
                                    <p class="para2">12 people researching this project</p>
                                </div>
                            </div>
                        </a>
                        <a href="Javascript:updateURL(3)">
                            <div
                                class="item item_desc item1_desc"
                                style="background-image: url('Doc/images/bg.png'),
                  url('Doc/images/thumb03.jpg'); background-repeat: no-repeat; background-size: cover; background-attachment: local;">
                                <div class="item_descs">
                                    <h4>Thiland</h4>
                                    <h2>TEACH ENGLISH ABROAD</h2>
                                    <p class="para1">Global Volunteering International</p>
                                    <p class="para2">12 people researching this project</p>
                                </div>
                            </div>
                        </a>
                        <a href="Javascript:updateURL(4)">
                            <div
                                class="item item_desc item1_desc"
                                style="background-image: url('Doc/images/bg.png'),
                  url('Doc/images/thumb04.jpg'); background-repeat: no-repeat; background-size: cover; background-attachment: local;">
                                <div class="item_descs">
                                    <h4>India</h4>
                                    <h2 style="color: #ff0051 !important">DENTAL CARE ABROAD</h2>
                                    <p class="para1">Global Volunteering International</p>
                                    <p class="para2">12 people researching this project</p>
                                </div>
                            </div>
                        </a>
                        <a href="Javascript:updateURL(5)">
                            <div
                                class="item item_desc item1_desc"
                                style="background-image: url('Doc/images/bg.png'),
                  url('Doc/images/thumb05.jpg'); background-repeat: no-repeat; background-size: cover; background-attachment: local;">
                                <div class="item_descs">
                                    <h4>Costa Rica</h4>
                                    <h2>MEDICAL SUPPORT IN QAPOS</h2>
                                    <p class="para1">Global Volunteering International</p>
                                    <p class="para2">12 people researching this project</p>
                                </div>
                            </div>
                        </a>
                        <a href="Javascript:updateURL(6)">
                            <div
                                class="item item_desc item1_desc"
                                style="background-image: url('Doc/images/bg.png'),
                  url('Doc/images/thumb06.jpg'); background-repeat: no-repeat; background-size: cover; background-attachment: local;">
                                <div class="item_descs">
                                    <h4>Thiland</h4>
                                    <h2>TEACH ENGLISH ABROAD</h2>
                                    <p class="para1">Global Volunteering International</p>
                                    <p class="para2">12 people researching this project</p>
                                </div>
                            </div>
                        </a>
                    </div>
                </div>

                <!-- Carousel-2 ******* -->
                <div class="featuresDestination">
                    <h2>Feature Destination</h2>
                    <div class="owl-carousel owl-theme slider22">
                        <a href="Javascript:updateURL(7)">
                            <div
                                class="item item_desc_feature item2_desc"
                                style="background-image: url('Doc/images/bg.png'),
                  url('Doc/images/thumb10.jpg'); background-repeat: no-repeat; background-size: cover;">
                                <div class="item_desc">
                                    <p>37 project in</p>
                                    <h2>KENYA</h2>
                                </div>
                            </div>
                        </a>
                        <a href="Javascript:updateURL(8)">
                            <div
                                class="item item_desc_feature item2_desc"
                                style="background-image: url('Doc/images/bg.png'),
                  url('Doc/images/thumb11.jpg'); background-repeat: no-repeat; background-size: cover;">
                                <div class="item_desc">
                                    <p>37 project in</p>
                                    <h2>TURKMENISTAN</h2>
                                </div>
                            </div>
                        </a>
                        <a href="Javascript:updateURL(9)">
                            <div
                                class="item item_desc_feature item2_desc"
                                style="background-image: url('Doc/images/bg.png'),
                  url('Doc/images/thumb12.jpg'); background-repeat: no-repeat; background-size: cover;">
                                <div class="item_desc">
                                    <p>37 project in</p>
                                    <h2>SOUTH AFRICA</h2>
                                </div>
                            </div>
                        </a>
                        <a href="Javascript:updateURL(10)">
                            <div
                                class="item item_desc_feature item2_desc"
                                style="background-image: url('Doc/images/bg.png'),
                  url('Doc/images/thumb13.jpg'); background-repeat: no-repeat; background-size: cover;">
                                <div class="item_desc">
                                    <p>37 project in</p>
                                    <h2>BOLIVIA</h2>
                                </div>
                            </div>
                        </a>
                        <a href="Javascript:updateURL(11)">
                            <div
                                class="item item_desc_feature item2_desc"
                                style="background-image: url('Doc/images/bg.png'),
                  url('Doc/images/thumb14.jpg'); background-repeat: no-repeat; background-size: cover;">
                                <div class="item_desc">
                                    <p>37 project in</p>
                                    <h2>AFRICA</h2>
                                </div>
                            </div>
                        </a>
                        <a href="Javascript:updateURL(12)">
                            <div
                                class="item item_desc_feature item2_desc"
                                style="background-image: url('Doc/images/bg.png'),
                  url('Doc/images/thumb15.jpg'); background-repeat: no-repeat; background-size: cover;">
                                <div class="item_desc">
                                    <p>37 project in</p>
                                    <h2>INDIA</h2>
                                </div>
                            </div>
                        </a>
                        <a href="Javascript:updateURL(13)">
                            <div
                                class="item item_desc_feature item2_desc"
                                style="background-image: url('Doc/images/bg.png'),
                  url('Doc/images/thumb16.jpg'); background-repeat: no-repeat; background-size: cover;">
                                <div class="item_desc">
                                    <p>37 project in</p>
                                    <h2>INDIA</h2>
                                </div>
                            </div>
                        </a>
                    </div>
                </div>

                <!-- Carousel-3 ******* -->
                <div class="featuresDestination">
                    <h2>Most Affordable Projects</h2>
                    <div class="owl-carousel owl-theme slider33">
                        <a href="Javascript:updateURL(14)">
                            <div
                                class="item item_afford item3_desc"
                                style="background-image: url('Doc/images/bg.png'),
                    url('Doc/images/thumb16.jpg'); background-repeat: no-repeat; background-size: cover;">
                                <div class="item_descs">
                                    <span>Starting at</span>
                                    <p class="para12">$299/week</p>
                                    <span>for 4 Weeks</span>
                                    <h5>Surf School for Children</h5>
                                </div>
                            </div>
                            <div
                                class="bottomTxt"
                                style="display: flex; flex-direction: column">
                                <h6>South Africa</h6>
                                <p class="para2">Global Volunteering International</p>
                            </div>
                        </a>
                        <a href="Javascript:updateURL(15)">
                            <div
                                class="item item_afford item3_desc"
                                style="background-image: url('Doc/images/bg.png'),
                    url('Doc/images/thumb17.jpg'); background-repeat: no-repeat; background-size: cover;">
                                <div class="item_descs">
                                    <span>Starting at</span>
                                    <p class="para12">$299/week</p>
                                    <span>for 4 Weeks</span>
                                    <h5>Animal Care</h5>
                                </div>
                            </div>
                            <div
                                class="bottomTxt"
                                style="display: flex; flex-direction: column">
                                <h6>South Africa</h6>
                                <p class="para2">Global Volunteering International</p>
                            </div>
                        </a>
                        <a href="Javascript:updateURL(16)">
                            <div
                                class="item item_afford item3_desc"
                                style="background-image: url('Doc/images/bg.png'),
                    url('Doc/images/thumb18.jpg'); background-repeat: no-repeat; background-size: cover;">
                                <div class="item_descs">
                                    <span>Starting at</span>
                                    <p class="para12">$299/week</p>
                                    <span>for 4 Weeks</span>
                                    <h5>Medical Support in Qapos</h5>
                                </div>
                            </div>
                            <div
                                class="bottomTxt"
                                style="display: flex; flex-direction: column">
                                <h6>South Africa</h6>
                                <p class="para2">Global Volunteering International</p>
                            </div>
                        </a>
                        <a href="Javascript:updateURL(17)">
                            <div
                                class="item item_afford item3_desc"
                                style="background-image: url('Doc/images/bg.png'),
                    url('Doc/images/thumb19.jpg'); background-repeat: no-repeat; background-size: cover;">
                                <div class="item_descs">
                                    <span>Starting at</span>
                                    <p class="para12">$299/week</p>
                                    <span>for 4 Weeks</span>
                                    <h5>Teach English & French</h5>
                                </div>
                            </div>
                            <div
                                class="bottomTxt"
                                style="display: flex; flex-direction: column">
                                <h6>South Africa</h6>
                                <p class="para2">Global Volunteering International</p>
                            </div>
                        </a>
                        <a href="Javascript:updateURL(18)">
                            <div
                                class="item item_afford item3_desc"
                                style="background-image: url('Doc/images/bg.png'),
                    url('Doc/images/thumb20.jpg'); background-repeat: no-repeat; background-size: cover;">
                                <div class="item_descs">
                                    <span>Starting at</span>
                                    <p class="para12">$299/week</p>
                                    <span>for 4 Weeks</span>
                                    <h5>Build Houses abroad</h5>
                                </div>
                            </div>
                            <div
                                class="bottomTxt"
                                style="display: flex; flex-direction: column">
                                <h6>South Africa</h6>
                                <p class="para2">Global Volunteering International</p>
                            </div>
                        </a>
                        <a href="Javascript:updateURL(19)">
                            <div
                                class="item item_afford item3_desc"
                                style="background-image: url('Doc/images/bg.png'),
                    url('Doc/images/thumb21.jpg'); background-repeat: no-repeat; background-size: cover;">
                                <div class="item_descs">
                                    <span>Starting at</span>
                                    <p class="para12">$299/week</p>
                                    <span>for 4 Weeks</span>
                                    <h5>Medical Support in Qapos</h5>
                                </div>
                            </div>
                            <div
                                class="bottomTxt"
                                style="display: flex; flex-direction: column">
                                <h6>South Africa</h6>
                                <p class="para2">Global Volunteering International</p>
                            </div>
                        </a>
                        <a href="Javascript:updateURL(20)">
                            <div
                                class="item item_desc item3_desc"
                                style="background-image: url('Doc/images/bg.png'),
                    url('Doc/images/thumb22.jpg'); background-repeat: no-repeat; background-size: cover;">
                                <div class="item_descs">
                                    <span>Starting at</span>
                                    <p class="para12">$299/week</p>
                                    <span>for 4 Weeks</span>
                                    <h5>Animal Care</h5>
                                </div>
                            </div>
                            <div
                                class="bottomTxt"
                                style="display: flex; flex-direction: column">
                                <h6>South Africa</h6>
                                <p class="para2">Global Volunteering International</p>
                            </div>
                        </a>
                    </div>
                </div>
            </div>

            <!-- **** footer -->
            <div class="footer">
                <div class="logo">
                    <img
                        class="mainLogo"
                        src="Doc/images/logo_1.png"
                        alt="Footer - Logo" />
                </div>
                <div class="faqs">
                    <ul>
                        <li>FAQ</li>
                        <li>CONTACT US</li>
                    </ul>
                </div>
            </div>

        </form>

        <script>
            function updateURL(projectId) {
                window.location.href = `../Home/home.aspx?projectid=` + projectId;
            }
        </script>

        <script>
            $(".slider12").owlCarousel({
                loop: true,
                margin: 25,
                nav: true,
                responsive: {
                    0: {
                        items: 1,
                    },
                    651: {
                        items: 2,
                    },
                    900: {
                        items: 4,
                    },
                },
            });

            // second slider
            $(".slider22").owlCarousel({
                loop: true,
                margin: 25,
                nav: true,
                responsive: {
                    0: {
                        items: 2,
                    },
                    651: {
                        items: 3,
                    },
                    900: {
                        items: 6,
                    },
                },
            });

            // third slider
            $(".slider33").owlCarousel({
                loop: true,
                margin: 25,
                nav: true,
                responsive: {
                    0: {
                        items: 1,
                    },
                    651: {
                        items: 3,
                    },
                    900: {
                        items: 5,
                    },
                },
            });
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
            $("#location_input").autocomplete({
                source: autoTags,
            });
        </script>

        <!-- dropkick -->
        <script>
            $(function () {
                $("#type_select, #activity_select").dropkick({
                    mobile: true,
                });
            });
        </script>

        <script
            src="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/owl.carousel.min.js"
            integrity="sha512-bPs7Ae6pVvhOSiIcyUClR7/q2OAsRiovw4vAkX+zJbw3ShAeeqezq50RIIcIURq7Oa20rW2n2q+fyXBNcU9lrw=="
            crossorigin="anonymous"
            referrerpolicy="no-referrer"></script>

        <script src="script.js"></script>
    </main>
</body>
</html>

