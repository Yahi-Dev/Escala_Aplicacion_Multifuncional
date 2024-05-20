// //app.js
const nombre = document.getElementById("name");
const apellido = document.getElementById("last-name");
const usuarioname = document.getElementById("username");
const email = document.getElementById("email");
const password = document.getElementById("password");
const number = document.getElementById("number-phone");
const enviar = document.getElementById("submit");

enviar.addEventListener("click", enviarData);

function enviarData(e) {
  if (
    nombre.value &&
    apellido.value &&
    usuarioname.value &&
    email.value &&
    password.value &&
    number.value
  ) {
    e.preventDefault();
    window.location = "../HTML/Login.html";
    const info = {
      name: nombre.value,
      lastName: apellido.value,
      userName: usuarioname.value,
      mailAddress: email.value,
      password: password.value,
      phoneNumber: number.value,
    };
    fetch("https://localhost:7139/Prac3/registrar", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(info),
    })
      .then((response) => response.json())
      .then((data) => {
        console.log(data);
      })
      .catch((error) => console.error("Error: ", error));
  } else {
    e.preventDefault();

    alert("XXX Por favor, llene todos los registros XXX");
  }
}