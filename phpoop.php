<?php

class AgeChecker
{
    public function isAdult(int $age): string
    {
        return $age >= 18 ? 'adult' : 'minor';
    }

    public function main(): void
    {
        $ages = [15, 18, 25, 10];
        
        foreach ($ages as $age) {
            $status = $this->isAdult($age);
            echo "Yaş: {$age} -> Durum: {$status}\n";
        }
    }
}

$checker = new AgeChecker();
$checker->main();