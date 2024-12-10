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




