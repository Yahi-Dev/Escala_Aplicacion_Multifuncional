document.addEventListener("DOMContentLoaded", function(){
    const submitButtonTem = document.getElementById("submitTem");
    const resultadoConvertirInputTem = document.getElementById("resultadoTem");
    const numero1InputTem = document.getElementById("numero1Tem");


    submitButtonTem.addEventListener("click", function(event){

        event.preventDefault();
        const datosOperacionTem = numero1InputTem.value;

        if (datosOperacionTem) {
            const info ={
                user: localStorage.getItem("username"),
                dato: parseFloat(datosOperacionTem)
            };

            fetch("https://localhost:7139/Prac3/conversionTemperatura", {
                method: "POST",
                headers:{
                    "Content-Type": "application/json"
                },
                body: JSON.stringify(info),
            });
            then(response => {
                if (response.ok) {
                    return response.text();
                }
                else{
                    throw new Error("Favor ingrese datos");
                }
            })
            .then(data => {
                resultadoConvertirInputTem.value = data;
            })
            .catch(error => {
                console.error("Error en la solicitud fetch", error);
            });
        }
        else{
            alert("Por favor, ingrese una cantidad en dólares");
        }
    })
})