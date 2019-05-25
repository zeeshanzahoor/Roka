import React from 'react';
import PropTypes from 'prop-types';
import { TextValidator } from 'react-material-ui-form-validator';

class ArtifexText extends React.Component {
    constructor(props) {
        super(props);
        this.handleChange = this.handleChange.bind(this);
        this.handleBlur = this.handleBlur.bind(this);
    }
    handleChange(e) {
        e.preventDefault();
        if (this.props.handleChange) {
            this.props.handleChange();
        }
    }
    handleBlur(event) {
        this.refs[event.target.name].validate(event.target.value);
        if (this.props.handleBlur) {
            this.props.handleBlur();
        }
    }
    render() {
        return (
            <TextValidator
                onChange={this.handleChange}
                fullWidth
                onBlur={this.handleBlur}
                ref={this.props.name}
                value={this.props.model[this.props.name]}
                autoComplete="off"
                {...this.props} />
        );
    }
}

export { ArtifexText };