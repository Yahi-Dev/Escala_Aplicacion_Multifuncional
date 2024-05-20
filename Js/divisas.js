document.addEventListener("click", function(){
    
    const submitButton = document.getElementById("submitConvertir");
    const resultadoConvertirInput = document.getElementById("resultadoconvertir");
    const numero1Input = document.getElementById("numero1");

    submitButton.addEventListener("click", function(event){
        event.preventDefault();
        const datosOperacion = numero1Input.value;

        if (datosOperacion) {
            const info = {
                user: localStorage.getItem("username"),
                dato: parseFloat(datosOperacion)
            };

            fetch("https://localhost:7139/Prac3/conversionMoneda", {
                method: "POST",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify(info)
            })
            .then(response => {
                if (response.ok) {
                    return response.text();
                }
                else{
                    throw new Error("Favor ingrese datos");
                }
            })
            .then(data => {
                resultadoConvertirInput.value = data;
                alert(data);
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