<?php
// Задание 2 - написать функцию, которая принимает три параметра:

//cap это количество людей, которое может вместить автобус, без учета водителя.
//on количество человек в автобусе без учета водителя.
//wait количество людей, ожидающих посадки в автобус, без учета водителя.
//Если места достаточно, верните 0, а если нет, верните количество пассажиров, которых он не может взять.
 
function enough($cap, $on, $wait) {
    $peoples = $on + $wait;
      if ($peoples <= $cap) {
          return 0;
      } else {
          return $peoples - $cap; 
      }
  }
    print_r(enough(10, 6, 5));