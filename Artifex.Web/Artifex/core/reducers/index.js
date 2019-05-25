import { combineReducers } from 'redux';

import { Authentication } from './Authentication.Reducer';

const rootReducer = combineReducers({
    Authentication,
});

export default rootReducer;