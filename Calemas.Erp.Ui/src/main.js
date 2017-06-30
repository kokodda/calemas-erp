﻿import Vue from 'vue'
import App from './app'
import router from './router'

import Notifications from 'vue-notification'
Vue.use(Notifications)

import select from './common/select'

import VeeValidate from 'vee-validate';
Vue.use(VeeValidate, {
    errorBagName: 'formErrors',
    fieldsBagName: 'formFields',
    locale: 'pt'
});

require('vue-strap/dist/vue-strap-lang.js')

const Moment = require('moment')
require('moment/locale/pt')
Vue.use(require('vue-moment'), { Moment });

import '../static/scss/style.scss'

new Vue({
    el: '#app',
    router,
    template: '<App/>',
    components: { App }
})
