import React from 'react';
import PropTypes from 'prop-types';
import { Button, CircularProgress} from '@material-ui/core';


class ArtifexButton extends React.Component {
    constructor(props) {
        super(props);
    }
    render() {
        return (
            <Button variant="contained" color="primary" className="no-radius" type="submit" {...this.props}>
                {this.props.loading && <CircularProgress color='inherit' size={20} style={{ marginRight:5, }} />} {this.props.children}
             </Button>
        );
    }
}


export { ArtifexButton };