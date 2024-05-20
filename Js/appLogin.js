//appLogin.js
$(document).ready(function () {
  $("#submitinicio").click(function (event) {
    event.preventDefault();

    var userName_usuario = $("#usernameinicio").val();
    var password_usuario = $("#passwordinicio").val();

    var info = {
      userName: userName_usuario ,
      password: password_usuario
    };

    fetch("https://localhost:7139/Prac3/iniciarsesion", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(info),
    })
    .then(function(response){
      if(response.ok)
      {
        return response.text();
      }
      else{
        throw new Error("Datos no existentes, favor registarse");
      }
    })
    .then(function(data){
      if (data === "Inicio de sesion exitoso") {
        localStorage.setItem("username", userName_usuario)
        window.location = "Menu.html";
      }
      else{
        throw new Error("Inicio de sesion fallido");
      }
    })
    .catch(function(error){
      $("#resultado").text(error.message);
    })
  });
});
