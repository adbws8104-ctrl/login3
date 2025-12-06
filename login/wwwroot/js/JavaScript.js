<script>
    document.getElementById("loginForm").addEventListener("submit", function (e) {
        let email = document.getElementById("email").value.trim();
    let password = document.getElementById("password").value.trim();

    if (email === "" || password === "") {
        e.preventDefault();
    alert("All fields must be filled out");
        }

    if (!email.includes("@")) {
        e.preventDefault();
    alert("Enter a valid email");
        }
    });
</script>