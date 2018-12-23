class Bike{
    constructor(public maxspeed: number,public price:number, public miles:number) {
        this.maxspeed = maxspeed;
        this.miles = miles;
        this.price = price;
    }
    displayinfo() {
        console.log(this.maxspeed, this.price, this.miles);
        return this;
    }
    ride() {
        this.miles += 10;
        return this;
    }
    reverse() {
        this.miles -= 6;
        return this
    }
}
var bike1 = new Bike(5, 5, 5);
var bike2 = new Bike(5, 5, 5);
var bike3 = new Bike(5, 5, 5);
bike1.ride().ride().ride().reverse().displayinfo();
bike2.ride().ride().reverse().reverse().displayinfo();
bike3.reverse().reverse().reverse().reverse().displayinfo();

