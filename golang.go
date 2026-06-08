package main

import "fmt"

type Person struct {
	Name string
	Age  int
}

func is_Adult(p Person) bool {	
	return p.Age >= 18 
}

func main() {
	p := Person{Name: "Alice", Age: 30}
	fmt.Printf("Name: %s, Age: %d\n", p.Name, p.Age)
	fmt.Printf("Is adult: %t\n", is_Adult(p))
}

