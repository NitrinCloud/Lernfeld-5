package de.rbztechnik.task.tasks

import de.rbztechnik.task.TaskProcessor

class GardenFence: TaskProcessor {

    override fun process() {
        println("Der geheime Code lautet: ${decode("HABEAMSONNTAGKEINEZEITMUSSLERNENSORRY")}")
        println("Der nicht mehr geheime Code lautet: ${encode("LEEMTEOAEENLMTITROLNIBRIVRNKGLASIDEEBHE")}")
        println("Der nicht mehr geheime Code lautet: ${encode("AMTWCFLEDERTNWITNEASMITOHALNIESEZESUDNU")}")
    }

    private fun decode(message: String): String {
        var first = "";
        var second = "";
        for (i in message.indices) {
            val character = message[i]
            if (i % 2 == 0) {
                first = first.plus(character)
            } else {
                second = second.plus(character)
            }
        }
        return first.plus(second)
    }

    private fun encode(message: String): String {
        val inputLength = message.length / 2
        val length = inputLength + message.length % 2

        var output = ""
        for (i in 0 until length) {
            output = output.plus(message[i])

            if (i < inputLength) {
                output = output.plus(message[length + i])
            }
        }
        return output;
    }

    override fun getName(): String = "GardenFence"
}