let lifes
let points
let rounds

window.onload = function () {
    Start()
    rounds=1
    Hide("table",true)
}

function Start (){
   Hide("numRamdon",true)

    rounds++
    lifes=3
    points=30
    
    NumRamdon()
    ResetNum()
    Hide("life1",false)
    Hide("life2",false)
    Hide("life3",false)
    Disabled("buttonMax",false)
    Disabled("buttonMin",false)
    Message("Prueba tu suerte","orange")
    MessageTitle("Adivina el número entre 0 y 20")
    loadPoints(points)
    Hide("buttonPlay",false)
    Hide("buttonStart",true)
    HeartReset();
}

function End(){
    Hide("numRamdon",false)
    Disabled("buttonMax",true)
    Disabled("buttonMin",true)
    Hide("buttonPlay",true)
    Hide("buttonStart",false)
    Score()
    Hide("table",false)
}

function Play (){
    let gameStatus
    
    switch(CompareNum()){
        case 0:
            Message("Acertaste !!","dodgerblue")
            Hide("numRamdon",false)
            End()
            MessageWin(points)
            break
        case 1:
            Message("Intenta con un número más bajo","orange")
            HideHeart(lifes)
            lifes--
            points-=10
            break
        case -1:
            Message("Intenta con un número más alto","orange")
            HideHeart(lifes)
            lifes--
            points-=10
            break
    }
    loadPoints(points)
    ValidateLifes(lifes)
}

function ValidateLifes(lifes){
    if(lifes==0){
        Message("Perdiste !!","red")
        MessageTitle("No clasificas para culebrero")
        End()
    }
}

function MessageWin(points){
    switch(points){
        case 30:
            MessageTitle("Eres un DIOS.. Genio..")
            break
        case 20:
            MessageTitle("Eres un Shaman adivinador.. ")
            break
        case 10:
            MessageTitle("Estás camino a ser brujo.. ")
            break
    }
}

function Score (){

    let round = "Ronda "+rounds

    let table = document.getElementById('table')
    let row= document.createElement('tr');

    let rowRound = document.createElement('td');
    rowRound.innerHTML = round;
    let rowPoint = document.createElement('td');
    rowPoint.innerHTML = points;
    
    row.appendChild(rowRound);
    row.appendChild(rowPoint);
    table.appendChild(row);
}

function ValidateCheck(){
    const check = document.getElementById("check")
    if(check.checked){
        Hide("numRamdon",false)
      } else {
        Hide("numRamdon",true)
      }
}

function prueba(){
    Round()
}