function NumMax (){
const input = document.getElementById("inputNum")
const inputVal = parseInt(input.value)
if(inputVal>=0 && inputVal<20)input.value=inputVal+1
else input.value=0
}

function NumMin (){
    const input = document.getElementById("inputNum")
    const inputVal = parseInt(input.value)
    if(inputVal>0 && inputVal<=20)input.value=inputVal-1
}

function NumRamdon(){
    const input = document.getElementById("numRamdon")
    const num = Math.round (Math.random()*20)
    input.value = num
}

function HideHeart(num){
    let life= "life"+num
    const heart = document.getElementById(life)
    heart.style.backgroundImage="url('./images/heartNull.png')"
}

function HeartReset(){
    for (let i=1;i<=3;i++){
        let life="life"+i
        document.getElementById(life).style.backgroundImage="url('./images/heart2.png')"
    }
}

function CompareNum(){
const numRamdon = parseInt(document.getElementById("numRamdon").value)
const inputNum = parseInt(document.getElementById("inputNum").value)
let result
if (numRamdon==inputNum) result=0
if (numRamdon<inputNum) result=1
if (numRamdon>inputNum) result=-1
return result 
}

function Hide (id,bool){
    const select = document.getElementById(id)
    select.hidden=bool
}

function Disabled(id,bool){
    document.getElementById(id).disabled = bool
}

function loadPoints(num){
    document.getElementById("numResult").value=num
}

function Message(message, color){
    const input = document.getElementById("inputMessage")
    input.value=message
    input.style.background=color
}

function MessageTitle(message){
    document.getElementById("textTitle").value=message 
}
    
function ResetNum (){
    const input = document.getElementById("inputNum")
    input.value=0
}

