import React from 'react';
import PropTypes from 'prop-types';
import { ValidatorForm } from 'react-material-ui-form-validator';

class ArtifexForm extends React.Component {
    constructor(props) {
        super(props);
        this.handleSubmit = this.handleSubmit.bind(this);
    }
    handleSubmit(e) {
        e.preventDefault();
        if (this.props.onSubmit) {
            this.props.onSubmit(e);
        }
    }

    render() {
        return (
            <ValidatorForm {...this.props} onSubmit={this.handleSubmit}>
                {this.props.children}
            </ValidatorForm>
        );
    }
}

export { ArtifexForm };