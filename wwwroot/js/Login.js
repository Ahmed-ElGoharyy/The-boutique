// Function to show error message
function showError(inputElement, message) {
    clearError(inputElement);

    const errorDiv = document.createElement("div");
    errorDiv.className = "error-message";
    errorDiv.textContent = message;
    inputElement.parentElement.appendChild(errorDiv);

    inputElement.classList.add("input-error");
}

// Function to clear error message
function clearError(inputElement) {
    const errorDiv = inputElement.parentElement.querySelector(".error-message");
    if (errorDiv) {
        errorDiv.remove();
    }
    inputElement.classList.remove("input-error");
}

// Function to validate email format
function isValidEmail(email) {
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return emailRegex.test(email);
}

// Function to validate password strength
function isValidPassword(password) {
    const passwordRegex = /^(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$/;
    return passwordRegex.test(password);
}

// Function to validate username
function isValidUsername(username) {
    const usernameRegex = /^[a-zA-Z0-9_]{3,20}$/;
    return usernameRegex.test(username);
}

// Main validation function
function validateForm(event) {
    event.preventDefault();
    const form = event.target;
    const formTitle = form.querySelector(".title").textContent.trim();
    let isValid = true;

    // Clear all previous errors
    form.querySelectorAll(".error-message").forEach((error) => error.remove());
    form.querySelectorAll("input").forEach((input) => input.classList.remove("input-error"));

    if (formTitle === "Login") {
        const username = document.getElementById("login_username");
        const password = document.getElementById("login_password");

        if (!username.value.trim()) {
            showError(username, "Username is required.");
            isValid = false;
        }

        if (!password.value.trim()) {
            showError(password, "Password is required.");
            isValid = false;
        } else if (!isValidPassword(password.value.trim())) {
            showError(password, "Password must be at least 8 characters long, include one uppercase letter and one number.");
            isValid = false;
        }

        if (isValid) {
            form.reset();
        }
    } else if (formTitle === "Sign Up") {
        const username = document.getElementById("signup_username");
        const email = document.getElementById("signup_email");
        const password = document.getElementById("signup_password");

        if (!username.value.trim()) {
            showError(username, "Username is required.");
            isValid = false;
        } else if (!isValidUsername(username.value.trim())) {
            showError(username, "Username must be 3-20 characters and contain only letters, numbers, and underscores.");
            isValid = false;
        }

        if (!email.value.trim()) {
            showError(email, "Email is required.");
            isValid = false;
        } else if (!isValidEmail(email.value.trim())) {
            showError(email, "Please enter a valid email address.");
            isValid = false;
        }

        if (!password.value.trim()) {
            showError(password, "Password is required.");
            isValid = false;
        } else if (!isValidPassword(password.value.trim())) {
            showError(password, "Password must be at least 8 characters long, include one uppercase letter and one number.");
            isValid = false;
        }

        if (isValid) {
            alert("Sign-Up successful!");
            form.reset();
        }
    }
}

// Add real-time validation
document.addEventListener("DOMContentLoaded", () => {
    document.querySelectorAll("input").forEach((input) => {
        input.addEventListener("input", function () {
            clearError(this);

            if (this.id === "signup_email" && this.value.trim() && !isValidEmail(this.value.trim())) {
                showError(this, "Please enter a valid email address.");
            }

            if ((this.id === "signup_username" || this.id === "login_username") && this.value.trim() && !isValidUsername(this.value.trim())) {
                showError(this, "Username must be 3-20 characters and contain only letters, numbers, and underscores.");
            }

            if ((this.id === "signup_password" || this.id === "login_password") && this.value.trim() && !isValidPassword(this.value.trim())) {
                showError(this, "Password must be at least 8 characters long, include one uppercase letter and one number.");
            }
        });
    });
});
