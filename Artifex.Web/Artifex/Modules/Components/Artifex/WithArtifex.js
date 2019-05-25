import React, { Component } from 'react';
import store from '../../../core/store/store'
import { connect } from 'react-redux';

export default function withArtifex(HocComponent) {
     class Hoc extends Component {
        constructor(props) {
            super(props);
        }
        render() {
            return (
                <div>
                    <HocComponent  {...this.props}></HocComponent>
                </div>
            );
        }
    }
    function mapStateToProps(state) {
        return state;
    }

    const connectedPage = connect(mapStateToProps)(Hoc);
    return connectedPage;
}

