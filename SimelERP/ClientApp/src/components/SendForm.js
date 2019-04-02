import React, { Component } from 'react'

export class SendForm extends Component {


    constructor(props) {
        super(props)

        this.state = {
            UpdateTestCommand: { Id : "1", name: "", text: "" }
        }
    }




    onSendedForm = (event) => {
        event.preventDefault()

     let command = this.state.UpdateTestCommand
    
        fetch('api/Test/Update?id=1', {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(command),
        });
    }

    onInputChanged = (event) => {
        let command = this.state.UpdateTestCommand;

        let InputName = event.target.name;
        let InputValue = event.target.value;

        command[InputName] = InputValue;

        this.setState({ command })
    }
    render() {
        return (
            <form onSubmit={this.onSendedForm}>
                <input
                    type="text"
                    name="name"
                    value={this.state.value}
                    onChange={this.onInputChanged}

                />
                <br />
                <br />
                <input
                    type="text"
                    name="text"
                    value={this.state.value}
                    onChange={this.onInputChanged}

                />
                <br />
                <br />
                <input
                    type="submit"
                    name="Send"
                  
                />

            </form>
        );
    }
}