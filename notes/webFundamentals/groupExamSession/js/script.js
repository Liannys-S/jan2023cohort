console.log('Wired up')

function changeImg(element) {
    console.log('activated mouse event')
    element.src = "./images/yankeeBoy.png"
}
function changeBack(element) {
    // console.log('new event')
    element.src ="./images/breezee.png"
}
let count = 0;
function addToCart(element) {
    console.log('button clicked')
    // let count = 0;
    if (count === 0) {
        count++
        // console.log('if triggered', count)
    } else {
        count++
        // console.log('else triggered', count)
    }
    document.getElementById('cart').innerText = count
}

function salePrices(element) {
    // console.log('button click')
    document.getElementById('sale').style.display = "none"
    let price = document.getElementsByClassName('price')
    // console.log(price)
    for(let i=0;i<price.length;i++){
        let temp = price[i].innerText
        // console.log(price[i].innerText)
        temp = temp-(temp*0.2)
        // console.log(temp)
        price[i].textContent = temp
    }
}