import React from 'react';
import PropTypes from 'prop-types';
import { CircularProgress } from '@material-ui/core';


const Loading = function (props) {
    var obj = Object.assign({}, props);
    delete obj.loading;
    delete obj.loadingHeight;
    return (
        <div className="center-content" style={{ height: props.loadingHeight ? props.loadingHeight : 'auto' }}>
            <CircularProgress color="primary" thickness={5} {...obj} />
        </div>
    );
};


class ArtifexLoadingPanel extends React.Component {
    constructor(props) {
        super(props);
    }


    render() {

        if (this.props.loading) {
            return (<Loading {...this.props} />);
        }
        else {
            return (this.props.children);
        }
    }
}

export { ArtifexLoadingPanel };