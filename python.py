class Age:
    def __init__(self, age):
        self.age = age
        
    def is_adult(self):
        return print("Adult" if self.age >= 18 else "Not an adult")
        
Age = Age(20)
print(Age.is_adult())