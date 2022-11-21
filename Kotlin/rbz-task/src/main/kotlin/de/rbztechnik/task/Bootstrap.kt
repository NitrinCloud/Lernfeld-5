package de.rbztechnik.task

import de.rbztechnik.task.tasks.GardenFence
import de.rbztechnik.task.tasks.MagicNumber
import de.rbztechnik.task.tasks.Quiz
import de.rbztechnik.task.tasks.Skytale

fun main() {
    val taskSystem = TaskSystem()
    taskSystem.addTask(GardenFence())
    taskSystem.addTask(Skytale())
    taskSystem.addTask(Quiz())
    taskSystem.addTask(MagicNumber())

    taskSystem.process()
}