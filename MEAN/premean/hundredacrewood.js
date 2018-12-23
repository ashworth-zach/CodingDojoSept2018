var piglet = {
    character: "Piglet",
    greet: function(){
        console.log("PPPPPPPPPPPIIIIIIIIIIIIIIIIIIIIIIIIIIIIGGGGGGGGGGGGGGGGGGGGGLLLLLLLLLLLLLLLLLEEEEEEEEEEEEEEEEEEEETTTTTTTTTTTTTTTTTTTTTTT");
        },
        drop: function(){
            console.log("cant drop honey here")
            }
};
var pooh = {
    character: "Winnie the Pooh",
    greet: function(){
        console.log("oh brother");
        },
        drop: function(){
            honey-=1;
            console.log("You delivered the honey to pooh")
            }
};
var tigger = {
    character: "Tigger",
    greet: function(){
        console.log("The wonderful thing about Tiggers is Tiggers are wonderful things!");
        },
        drop: function(){
            console.log("cant drop honey here")
            }
};
var bees = {
    character: "Bees",
    greet: function(){
        console.log("The wonderful thing about Tiggers is Tiggers are wonderful things!");
        },
        pickup: function(){
            honey+=1;
            console.log("You picked up some honey!")
            },
            drop: function(){
                console.log("cant drop honey here")
                }
};
var owl = {
    character: "Owl",
    greet: function(){
        console.log("The wonderful thing about Tiggers is Tiggers are wonderful things!");
        },
        drop: function(){
            console.log("cant drop honey here")
            }
};
var christopher = {
    character: "Christopher Robin",
    greet: function(){
        console.log("The wonderful thing about Tiggers is Tiggers are wonderful things!");
        },
        drop: function(){
            console.log("cant drop honey here")
            }
};
var rabbit = {
    character: "Rabbit",
    greet: function(){
        console.log("The wonderful thing about Tiggers is Tiggers are wonderful things!");
        },
        drop: function(){
            console.log("cant drop honey here")
            }
};
var gopher = {
    character: "Gopher",
    greet: function(){
        console.log("The wonderful thing about Tiggers is Tiggers are wonderful things!");
        },
        drop: function(){
            console.log("cant drop honey here")
            }
};
var kanga = {
    character: "Kanga",
    greet: function(){
        console.log("The wonderful thing about Tiggers is Tiggers are wonderful things!");
        },
        drop: function(){
            console.log("cant drop honey here")
            }
};
var eeyore = {
    character: "Eeyore",
    greet: function(){
        console.log("The wonderful thing about Tiggers is Tiggers are wonderful things!");
        },
        drop: function(){
            console.log("cant drop honey here")
            }
};
var heffalumps = {
    character: "Heffalumps",
    greet: function(){
        console.log("The wonderful thing about Tiggers is Tiggers are wonderful things!");
        },
        drop: function(){
            console.log("cant drop honey here")
            }
};
var pointer = piglet;
var honey = 0;


piglet.north = owl;
piglet.east = pooh;
tigger.north = pooh;
pooh.south = tigger;
pooh.west = piglet;
pooh.east = bees;
pooh.north = christopher;
christopher.south = pooh;
christopher.north = kanga;
owl.south = piglet;
owl.east = christopher;
bees.north = rabbit;
bees.west = pooh;
christopher.west = owl;
christopher.east = rabbit;
rabbit.south = bees;
rabbit.west = christopher;
rabbit.east = gopher;
gopher.west = rabbit;
kanga.south = christopher;
kanga.north = eeyore;
eeyore.south = kanga;
eeyore.east = heffalumps;
heffalumps.west = eeyore;

function Move(dir) {
    //     if(dir != "north" || dir != "south" || dir != "east" || dir != "west"){
    //         console.log("null input");
    //         return;
    //     }
    try {
        if (dir == "south") {
            console.log("you moved " + pointer.character + " to " + pointer.south.character + "'s house.")
            pointer = pointer.south;
        }
        if (dir == "east") {
            console.log("you moved " + pointer.character + " to " + pointer.east.character + "'s house.")
            pointer = pointer.east;
        }
        if (dir == "west") {
            console.log("you moved " + pointer.character + " to " + pointer.west.character + "'s house.")
            pointer = pointer.west;
        }
        if (dir == "north") {
            console.log("you moved " + pointer.character + " to " + pointer.north.character + "'s house.")
            pointer = pointer.north;
        } 
      if(dir!="south"&&dir!="north"&&dir!="east"&&dir!="west"){
        console.log("that is not a direction");
      }
    } 
    catch {
        console.log("error spot does not exist");
    }
  if(pointer.greet != undefined){
    pointer.greet();
  }
    return "you are at " + pointer.character;

}
function Pickup(){
    if(pointer.pickup!=undefined){
    pointer.pickup();
    }
    else{
    console.log("nothing to pick up")
    }
    return;
}
function Drop(){
    if(honey>0){
    pointer.drop();
    }
    else{
        console.log("no honey to give :(.")
    }
    return;
}