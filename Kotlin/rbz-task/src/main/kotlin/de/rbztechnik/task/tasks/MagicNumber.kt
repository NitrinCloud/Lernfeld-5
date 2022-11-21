package de.rbztechnik.task.tasks

import de.rbztechnik.task.NUMBER_REGEX
import de.rbztechnik.task.TaskProcessor

class MagicNumber: TaskProcessor {

    override fun process() {
        println("Die MagicNumber lautet: ${getMagicNumber(182)}")
        var input: String? = null
        while (input == null) {
            println("Gebe eine Nummer ein...")
            val cache = readln()
            if (cache.matches(NUMBER_REGEX)) {
                input = cache
            }
        }
        println("Die MagicNumber lautet: ${getMagicNumber(input.toInt())}")
    }

    private fun getMagicNumber(number: Int): Int {
        val numbers = number.toString().split("").map {
            if (it.matches(NUMBER_REGEX)) {
                it.toInt()
            } else {
                0
            }
        }
        var magicNumber = 0
        for (index in numbers) {
            magicNumber += index
        }
        return magicNumber
    }

    override fun getName(): String = "MagicNumber"
}