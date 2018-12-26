var world = [[1,2,2,1,1,1,1,1,1,1,1,1],
             [1,1,1,1,1,1,1,1,1,1,1,1],
             [1,2,0,1,1,1,1,1,1,1,1,1],
             [1,2,2,1,1,1,1,1,1,1,1,1],
             [1,2,2,1,1,1,1,1,1,1,1,1],
             [1,2,2,1,1,1,1,1,1,1,1,1],
             [1,2,2,1,1,1,1,1,1,1,1,1]];
function displayWorld(){
    var output="";
    for(var i =0;i<world.length;i++){
        for(var j=0;j<world[i].length;j++){
            if (world[i][j] == 0){
                output +="<div class='brick'>"
            }
            else if (world[i][j] == 1){
                output +="<div class='space'>"
            }
            else if (world[i][j] == 2){
                output +="<div class='coin'>"
            }
            output+= "</div>\n";
        }
        console.log(output);
        document.getElementById("world").innerHTML = output;
    }
}
displayWorld();