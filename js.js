class Age {
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }
    isAdult() {
        return this.age >= 18;
    }
}

let person1 = new Age("Alice", 30);
console.log(person1.name);
console.log(person1.isAdult());

function selam(yas) {
    return console.log("adult") && yas >= 18;
}

console.log(selam(20));