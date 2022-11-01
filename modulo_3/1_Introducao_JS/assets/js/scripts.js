let count = 0;
var currentNumberWrapper = document.getElementById("currentNumber2");
var currentNumber = 0;
var currentNumberWrapper3 = document.getElementById("currentNumber3");
var currentNumber3 = 0;
var sub3 = document.getElementById('#subtrair3');

const CURRENT_NUMBER = document.getElementById('currentNumber');

function increment() {
	count++;
	CURRENT_NUMBER.innerHTML = count;
}

function decrement() {
	count--;
	CURRENT_NUMBER.innerHTML = count;
}

function increment_2() {
	currentNumber = currentNumber + 1;
    currentNumberWrapper.innerHTML = currentNumber;
}

function decrement_2() {
	currentNumber = currentNumber - 1;
    currentNumberWrapper.innerHTML = currentNumber;
}

function increment_3() { 
	currentNumber3 = currentNumber3 + 1;
    currentNumberWrapper3.innerHTML = currentNumber3;
    if(currentNumber3 >= 10){
        document.querySelector('#adicionar3').disabled = true;

    }

    if((currentNumber3 <= 9) || (currentNumber3 >= 1)){
        document.querySelector('#subtrair3').disabled = false;

    }
}

function decrement_3() {
	currentNumber3 = currentNumber3 - 1;
    currentNumberWrapper3.innerHTML = currentNumber3;

    if(currentNumber3 <= 0){
        document.querySelector('#subtrair3').disabled = true;
        sudocument.querySelector('#subtrair3').className = 'buttonDisabled';
    }

    if((currentNumber3 <= 9) || (currentNumber3 >= 1)){
        document.querySelector('#adicionar3').disabled = false;
        sudocument.querySelector('#adicionar3').className = '';

    }
}