using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace _06.State
{
    // CODER ICI

    public class Enonce
    {
        /*[Fact]
        public void _01_Creer_une_classe_Task()
        {
            Task task = new Task();

            Assert.NotNull(task);
        }*/

        /*[Fact]
        public void _02_Creer_une_classe_TodoState_avec_une_methode_Start_et_Close()
        {
            Task task = new Task();

            TodoState state = new TodoState();

            Assert.Equal("TODO -> IN PROGRESS", state.Start(task));
            Assert.Equal("INVALID TRANSITION", state.Close(task));
        }*/

        /*[Fact]
        public void _03_Creer_une_classe_InProgressState_avec_une_methode_Start_et_Close()
        {
            Task task = new Task();

            InProgressState state = new InProgressState();

            Assert.Equal("INVALID TRANSITION", state.Start(task));
            Assert.Equal("IN PROGRESS -> CLOSED", state.Close(task));
        }*/

        /*[Fact]
        public void _04_Creer_une_classe_ClosedState_avec_une_methode_Start_et_Close()
        {
            Task task = new Task();

            ClosedState state = new ClosedState();

            Assert.Equal("INVALID TRANSITION", state.Start(task));
            Assert.Equal("INVALID TRANSITION", state.Close(task));
        }*/

        /*[Fact]
        public void _05_Creer_une_interface_ITaskState_avec_une_methode_Start_et_Close_pour_unifier_TodoState_et_InProgressState_et_ClosedState()
        {
            Task task = new Task();

            ITaskState todoState = new TodoState();

            Assert.Equal("TODO -> IN PROGRESS", todoState.Start(task));
            Assert.Equal("INVALID TRANSITION", todoState.Close(task));

            ITaskState inProgressState = new InProgressState();

            Assert.Equal("INVALID TRANSITION", inProgressState.Start(task));
            Assert.Equal("IN PROGRESS -> CLOSED", inProgressState.Close(task));

            ITaskState closedState = new ClosedState();

            Assert.Equal("INVALID TRANSITION", closedState.Start(task));
            Assert.Equal("INVALID TRANSITION", closedState.Close(task));
        }*/

        /*[Fact]
        public void _06_Creer_une_propriete_State_dans_Task_et_implementer_les_changements_de_state()
        {
            ITaskState state;

            Task task = new Task();
            state = task.State;

            Assert.IsType<TodoState>(state);

            state.Close(task);
            state = task.State;

            Assert.IsType<TodoState>(state);

            state.Start(task);
            state = task.State;

            Assert.IsType<InProgressState>(state);

            state.Start(task);
            state = task.State;

            Assert.IsType<InProgressState>(state);

            state.Close(task);
            state = task.State;

            Assert.IsType<ClosedState>(state);

            state.Start(task);
            state = task.State;

            Assert.IsType<ClosedState>(state);

            state.Close(task);
            state = task.State;

            Assert.IsType<ClosedState>(state);
        }*/

        /*[Fact]
        public void _07_Creer_une_methode_Start_et_Close_dans_Task_qui_appele_la_methode_correspondante_de_la_propriete_State()
        {
            Task task = new Task();

            Assert.Equal("INVALID TRANSITION", task.Close());

            Assert.Equal("TODO -> IN PROGRESS", task.Start());

            Assert.Equal("INVALID TRANSITION", task.Start());

            Assert.Equal("IN PROGRESS -> CLOSED", task.Close());

            Assert.Equal("INVALID TRANSITION", task.Start());

            Assert.Equal("INVALID TRANSITION", task.Close());
        }*/
    }
}
