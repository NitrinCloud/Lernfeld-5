package de.rbztechnik.task

class TaskSystem {

    private val tasks = arrayListOf<TaskProcessor>()

    fun addTask(taskProcessor: TaskProcessor) {
        tasks.add(taskProcessor)
    }

    fun process() {
        tasks.forEach() { task ->
            val name = task.getName()
            println("Running task $name\n\n\n")
            task.process()
            println("\n\n\nStopping task $name")
        }
    }
}