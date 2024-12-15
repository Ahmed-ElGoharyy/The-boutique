document.addEventListener('DOMContentLoaded', () => {
    const logoLink = document.getElementById('homeLogoButton');
    const transitionPage = document.getElementById('transitionPage');

    // Ensure transition page is hidden initially
    if (transitionPage) {
        transitionPage.classList.remove('show');
    }

    // Logo click handler
    if (logoLink) {
        logoLink.addEventListener('click', (event) => {
            event.preventDefault();

            if (transitionPage) {
                // Show transition page
                transitionPage.classList.add('show');

                // Redirect after a short delay
                setTimeout(() => {
                    window.location.href = "/";
                }, 1000);
            }
        });
    }
});
document.addEventListener('DOMContentLoaded', () => {
    const navbarDropdown = document.getElementById('navbarDropdown');

    // Ensure dropdown opens/closes properly
    navbarDropdown.addEventListener('click', (event) => {
        event.preventDefault(); // Prevent default link behavior
        const parent = navbarDropdown.closest('.dropdown');
        parent.classList.toggle('show');
    });
});
