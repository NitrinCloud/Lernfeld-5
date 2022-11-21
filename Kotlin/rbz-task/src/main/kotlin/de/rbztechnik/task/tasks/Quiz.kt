package de.rbztechnik.task.tasks

import de.rbztechnik.task.TaskProcessor

class Quiz: TaskProcessor {

    override fun process() {
        println("Ausflugsplanung")
        println("---------------")
        println()

        val wochentag = Question(
            "Planes Sie, ihren Ausflug an einem Wochenende durchzuführen?",
            arrayOf("Wochenende", "Wochentag")
        ).askConsole().answer == "Wochentag"
        println("ds")
        val wochenEnde = !wochentag
        val schoenWetter = Question(
            "Bei welchem Wetter planen Sie, ihren Ausflug durchzuführen?",
            arrayOf("Sonne", "Regen")
        ).askConsole().answer == "Sonne"
        val schlechtWetter = !schoenWetter
        val ferien = Question(
            "Planen Sie, ihren Ausflug in den Ferien durchzuführen?",
            arrayOf("Ferien", "Schule")
        ).askConsole().answer == "Ferien"
        val schulzeit = !ferien
        val tagsueber = Question(
            "Planen Sie, ihren Ausflug Tagsüber durchzuführen?",
            arrayOf("Tag", "Abend")
        ).askConsole().answer == "Tag"
        val abends = !tagsueber
        val nurErwachsene = Question(
            "Planen Sie, einen Ausflug mit oder für Kinder organisieren?",
            arrayOf("j", "n")
        ).askConsole().answer != "j"

        val kegeln            = abends || wochenEnde
        val freibad           = schoenWetter && tagsueber
        val hallenbad         = !(ferien && wochenEnde)
        val musik             = abends && schulzeit
        val brotbackkurs      = wochenEnde && schlechtWetter
        val schieferbergwerk  = tagsueber || (wochenEnde && ferien)
        val goKurse           = (wochenEnde && schlechtWetter) || (wochentag && abends && schoenWetter)
        val billard           = nurErwachsene && (abends || wochenEnde)
        val rennauto          = nurErwachsene && tagsueber && ferien && wochenEnde
        val openAirKino       = schoenWetter && (abends || wochenEnde)
        val korbflechten      = ferien && schlechtWetter && wochentag

        println()
        println("---------------")
        println()

        if (kegeln) println("Kegeln")
        if (freibad) println("Freibad")
        if (hallenbad) println("Hallenbad")
        if (freibad) println("Wandern im Dunkelwald")
        if (musik) println("Musik")
        if (brotbackkurs) println("Brotbackkurs")
        if (schieferbergwerk) println("Schieferbergwerk")
        if (goKurse) println("Go Kurs")
        if (billard) println("Billiard")
        if (rennauto) println("Rennauto")
        if (openAirKino) println("Open-Air Kino")
        if (korbflechten) println("Korbflechten")
        if (tagsueber) println("Besuch des Wasserfalls")
        println("Zoobesuch")
    }

    override fun getName(): String = "Quiz"
}

class Question(private val question: String, private val answers: Array<String>) {

    var answer: String? = null

    fun askConsole(): Question {
        while (answer == null) {
            println(question)
            print("[")
            for (index in answers.indices) {
                if (index != answers.size - 1) {
                    print("${answers[index]},")
                }
            }
            print(answers.last())
            println("]")
            val cache = readln()

            if (answers.contains(cache)) {
                answer = cache
            }
        }
        return this
    }
}