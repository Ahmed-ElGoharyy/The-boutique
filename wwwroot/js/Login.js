function validateForm(e) {
    e.preventDefault(); // Prevent form submission for validation

    const username = document.getElementById("username");
    const email = document.getElementById("email");
    const password = document.getElementById("password");
    const confirmPassword = document.getElementById("confirmPassword");

    const usernameError = document.getElementById("usernameError");
    const emailError = document.getElementById("emailError");
    const passwordError = document.getElementById("passwordError");
    const confirmPasswordError = document.getElementById("confirmPasswordError");

    let isValid = true;

    // Reset error messages
    usernameError.innerText = "";
    emailError.innerText = "";
    passwordError.innerText = "";
    confirmPasswordError.innerText = "";

    // Username validation
    if (username.value.length < 3 || username.value.length > 25) {
        usernameError.innerText = "Username must be between 3 and 25 characters.";
        username.style.borderColor = "red";
        isValid = false;
    } else {
        username.style.borderColor = "green";
    }

    // Email validation
    const emailPattern = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/;
    if (!emailPattern.test(email.value)) {
        emailError.innerText = "Please enter a valid email address.";
        email.style.borderColor = "red";
        isValid = false;
    } else {
        email.style.borderColor = "green";
    }

    // Password validation
    const passwordPattern = /^(?=.[a-z])(?=.[A-Z])(?=.\d)(?=.[!@#$%^&])[A-Za-z\d!@#$%^&]{8,}$/;
    if (!passwordPattern.test(password.value)) {
        passwordError.innerText =
            "Password must be at least 8 characters, with 1 lowercase, 1 uppercase, 1 number, and 1 special character.";
        password.style.borderColor = "red";
        isValid = false;
    } else {
        password.style.borderColor = "green";
    }

    // Confirm Password validation
    if (password.value !== confirmPassword.value) {
        confirmPasswordError.innerText = "Passwords do not match.";
        confirmPassword.style.borderColor = "red";
        isValid = false;
    } else {
        confirmPassword.style.borderColor = "green";
    }

    if (isValid) {
        alert("Form submitted successfully!");
        // Optionally, submit the form here
        // document.getElementById("signUpForm").submit();
    }
}