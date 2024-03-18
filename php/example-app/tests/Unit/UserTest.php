<?php

namespace Tests\Unit;

use PHPUnit\Framework\TestCase;
use MyTests;

include __DIR__."../../../bubbleSort.php";

class UserTest extends TestCase
{
    public function test_example(): void
    {
        $this->assertTrue(true);
    }

    public function test_bubblesort(): void 
    {
        $myClass = new MyTests\MyClass();
        $this->assertEquals([1,2,3,4,5], $myClass->bubbleSort([2,3,4,5,1]));
    }
}
