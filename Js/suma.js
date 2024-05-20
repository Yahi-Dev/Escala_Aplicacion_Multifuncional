document.addEventListener("click", function(){


    const submitEnviar = document.getElementById("submitSuma");
    const resultado = document.getElementById("resultadoSuma");
    const numero1Input = document.getElementById("numero1Suma");
    const numero2Input = document.getElementById("numero2Suma");

    submitEnviar.addEventListener("click", function(event){

        event.preventDefault();
        const dato1 = numero1Input.value;
        const dato2 = numero2Input.value;

        if (dato1 && dato2) {
            const info = {
                nombreUser : localStorage.getItem("username"),
                numero1 : parseInt(dato1),
                numero2 : parseInt(dato2)
            };

            fetch("https://localhost:7139/Prac3/suma", {
                method: "POST",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify(info)
            })
            .then(response => {
                if (response.ok) {
                    return response.json();
                }
                else{
                    throw new Error("Favor ingrese datos");
                }
            })
            .then(data => {
                resultado.value = data;
                console.log(resultado);
            })
            .catch(error => {
                console.error("Error en la solicitud fetch", error);
            });
        }
        else{
            alert("Por favor, ingrese una cantidad en dólares");
        }
    });
});