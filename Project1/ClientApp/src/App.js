import React, { Component } from 'react';
import { Route, Routes } from 'react-router-dom';
import AppRoutes from './AppRoutes';
import { Layout } from './components/Layout';
import { Cinema } from './components/Cinema';

import './custom.css';

export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <div className="base-div">
                <div className="div-1">
                    <Cinema></Cinema>
                </div>
                <div className="div-2">A</div>
            </div>
        );
    }
}
