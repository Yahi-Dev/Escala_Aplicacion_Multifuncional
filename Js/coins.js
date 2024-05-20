function createCoin(){
    const coin = document.createElement("div");
    coin.className = 'coin';
    coin.style.left = `${Math.random() * 100}%`;
    document.querySelector('.coin-container').appendChild(coin);

    setTimeout(() => {
        coin.remove();
    }, 3000);
}

function generationCoins(){
    setInterval(createCoin, 500);
}

window.addEventListener('load', generationCoins);