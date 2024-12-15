// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const logoLink = document.getElementById('homeLogoButton');
const transitionPage = document.getElementById('transitionPage');

logoLink.addEventListener('click', (event) => {
    event.preventDefault(); // Prevent default link behavior

    transitionPage.classList.remove('hidden');

    setTimeout(() => {
     
        // Redirect to the homepage after the transition
        window.location.href = "/";

    }, 1500); // Adjust the delay as needed
 
});



/// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const logoLink = document.getElementById('homeLogoButton');
const transitionPage = document.getElementById('transitionPage');

logoLink.addEventListener('click', (event) => {
    event.preventDefault(); // Prevent default link behavior

    transitionPage.classList.remove('hidden');

    setTimeout(() => {

        // Redirect to the homepage after the transition
        window.location.href = "/";

    }, 1500); // Adjust the delay as needed

});
/* Base Responsive Font Sizing */
html {
    font - size: 14px;
    position: relative;
    min - height: 100 %;
}

@media(min - width: 576px) {
    html {
        font - size: 15px;
    }
}

@media(min - width: 768px) {
    html {
        font - size: 16px;
    }
}

@media(min - width: 992px) {
    html {
        font - size: 17px;
    }
}

/* Global Reset and Base Styles */
* {
    margin: 0;
    padding: 0;
    box- sizing: border - box;
}

body {
    font - family: -apple - system, BlinkMacSystemFont, "Segoe UI", Roboto, "Helvetica Neue", Arial, sans - serif;
    line - height: 1.6;
    margin - bottom: 45px;
    animation: fadeIn 0.55s ease -in -out;
    overflow - x: hidden;
    color: #333;
}

/* Focus States */
.btn: focus, 
.btn: active: focus, 
.btn - link.nav - link: focus, 
.form - control: focus, 
.form - check - input:focus {
    box - shadow: 0 0 0 0.1rem white, 0 0 0 0.25rem #258cfb;
    outline: none;
}

/* Navigation Responsive Adjustments */
@media(max - width: 991px) {
    .nav - item {
        margin - left: 0!important;
        margin - bottom: 10px;
        text - align: center;
    }

    #cartButton, #accButton {
        margin - left: 0!important;
    }
}

.nav - item {
    margin - left: 50px;
    font - size: large;
    font - weight: 400;
    transition: transform 0.2s ease;
}

.nav - item:hover {
    transform: translateY(-3px);
}

#shopButton {
    font - size: larger;
    font - weight: 500;
}

#cartButton {
    margin - left: 100px;
}

#accButton {
    margin - left: 10px;
}

#shopButton:hover {
    color: #007bff;
}

/* Footer Styles */
footer {
    width: 100 %;
    background - color: #f8f9fa;
    color: #333;
    text - align: center;
    padding: 15px 0;
}

/* Transition Page */
#transitionPage {
    position: fixed;
    top: 0;
    left: 0;
    width: 100 %;
    height: 100 %;
    background - color: white;
    display: flex;
    justify - content: center;
    align - items: center;
    z - index: 9999;
    opacity: 0;
    visibility: hidden;
    transition: opacity 0.5s ease;
}

.hidden {
    display: none;
}

#transitionLogo {
    width: 250px;
    height: auto;
    max - height: 250px;
    object - fit: contain;
    margin - top: 100px;
}

/* Fade In Animation */
.fade -in {
    opacity: 0;
    animation: fadeIn 1.3s ease-in -out forwards;
}

@keyframes fadeIn {
    from {
        opacity: 0;
        transform: translateY(20px);
    }
    to {
        opacity: 1;
        transform: translateY(0);
    }
}

/* Accessibility and Performance Improvements */
img {
    max - width: 100 %;
    height: auto;
}

/* Responsive Typography */
@media(max - width: 576px) {
    body {
        font - size: 0.9rem;
    }

    .nav - item {
        font - size: medium;
    }
}

/* Print Styles */
@media print {
    body {
        margin: 0;
    }

    #transitionPage {
        display: none;
    }
}

