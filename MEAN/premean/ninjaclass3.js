class Ninja {
    constructor(name, health) {
        this.strength = 3
        this.speed = 3
        this.name = name;
        this.health = health;
    }


    sayName() {
        console.log(this.name);
    }
    showStats() {
        console.log("Name: " + this.name + ", Speed: " + this.speed + ", Strength: " + this.strength + ", Health: " + this.health);
    }
    drinkSake() {
        console.log("ygghghghghgg");
        this.health += 10;
    }
    punch(ninja) {
        try {
            if (ninja.health == undefined) {
                console.log(ninja + "---ninja is invalid");
                return
            }
            console.log(ninja.health);
            ninja.health -= 5;
        } catch (err) {
            console.log(err);
        }
    }

    kick(ninja) {
        try {
            if (ninja.health == undefined) {
                console.log(ninja + "---ninja is invalid");
                return
            }
                      ninja.health -= 15 * this.strength;
            console.log(ninja.health);
        } catch (err) {
            console.log(err);
        }
    }
}
var x = new Ninja("zach", 200);
x.sayName();
x.showStats();
var y = new Ninja("enemyboi", 30);
var z = 0;
y.sayName();
x.punch(y);
x.punch(y);
x.drinkSake();
x.punch(y);
y.kick(x);
console.log("goteeem");