import React, { Component } from 'react';
import { SendForm } from './SendForm';

export class FetchData extends Component {
    static displayName = FetchData.name;

    constructor(props) {
        super(props);
        this.state = {
            test: { TestERPId: "", name: "", text: "" }, loading: true
        };

        fetch('api/Test/Get?id=1')
            .then(response => response.json())
            .then(data => {
                this.setState({ test: data, loading: false });
            });
    }



    //static renderForecastsTable (test) {
    //  return (
    //    <table className='table table-striped'>
    //      <thead>
    //        <tr>
    //          <th>Date</th>
    //          <th>Temp. (C)</th>
    //          <th>Temp. (F)</th>
    //          <th>Summary</th>
    //        </tr>
    //      </thead>
    //      <tbody>
    //        {test.map(test =>
    //          <tr key={test.Id}>
    //            <td>{test.name}</td>

    //          </tr>
    //        )}
    //      </tbody>
    //    </table>
    //  );
    //}


    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : <p>{this.state.test.TestERPId} {this.state.test.name}  {this.state.test.text}</p>;

        return (
            <div>
                <h1>Weather forecast</h1>
                <p>This component demonstrates fetching data from the server.</p>
                <div>{contents} </div>

                <SendForm/>
            </div>
        );
    }
}
