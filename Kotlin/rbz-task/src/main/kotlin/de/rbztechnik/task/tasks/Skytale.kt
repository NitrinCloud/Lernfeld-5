package de.rbztechnik.task.tasks

import de.rbztechnik.task.TaskProcessor
import kotlin.math.ceil

class Skytale: TaskProcessor {

    override fun process() {
        println("Der geheime Code lautet: ${decode("HABEAMSONNTAGKEINEZEITMUSSLERNENSORRY", 5)}")
        println("Der nicht mehr geheime Code lautet: ${encode("LEEMTEOAEENLMTITROLNIBRIVRNKGLASIDEEBHE", 2)}")
        println("Der nicht mehr geheime Code lautet: ${encode("AMTWCFLEDERTNWITNEASMITOHALNIESEZESUDNU", 2)}")
    }

    private fun decode(message: String, key: Int): String {
        val pages = ceil(message.length / key.toDouble()).toInt()
        val array = Array(pages) {Array(key) {' '} }
        var pageIndex = 0
        var charIndex = 0

        for (character in message) {
            array[pageIndex][charIndex] = character
            charIndex += 1

            if (charIndex != key) continue
            pageIndex += 1
            charIndex = 0
        }

        var code = ""
        for (i in 0 until key) {
            for (j in 0 until pages) {
                val character = array[j][i]

                if (character != ' ') {
                    code = code.plus(character)
                }
            }
        }
        return code
    }

    private fun encode(message: String, key: Int): String {
        val pages = ceil(message.length / key.toDouble()).toInt()
        val array = Array(pages) {Array(key) {' '} }
        var pageIndex = 0
        var charIndex = 0

        for (character in message) {
            array[pageIndex][charIndex] = character
            pageIndex += 1

            if (pageIndex != pages) continue
            pageIndex = 0
            charIndex += 1
        }

        var code = ""
        for (i in 0 until pages) {
            for (j in 0 until key) {
                val character = array[i][j]

                if (character != ' ') {
                    code = code.plus(character)
                }
            }
        }
        return code
    }

    override fun getName(): String = "Skytale"
}