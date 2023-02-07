<script setup>
import { ref } from 'vue';
import axios from 'axios';

defineProps({
  msg: String,
})

const count = ref(0);
const Title = ref("Hello CB17 C#");
let FirstLastName = ref("NO NAME");
let Name = ref({0: "NO", 1: "NAME", 55: 60, 54: undefined});
var weatherdata = 'weather';
const getWeatherData = async () => {
    await axios.get("https://localhost:7198/WeatherForecast").then(data => {
      console.log(data.data.lat);
      weatherdata = data.data.lat;
    });
  }
// getWeatherData().then(response => console.log(response));
</script>

<script>alert("Hello!!!!")</script>
<template>
  <h1>{{ msg }}</h1>

  <div class="card">
    <button type="button" @click="count++">count is {{ count }}</button>
    <p>
      Edit
      <code>components/HelloWorld.vue</code> to test HMR
    </p>
  </div>

  <h3>{{ FirstLastName }}</h3>
  <h4>{{ Name[0] }}&nbsp;{{ Name[1] }} {{ Name[55] }} {{ Name[54] }}</h4>
  <div><button @click="getWeatherData">Get Weather Data</button> <textarea v-model="weatherdata" /></div> 

  <p>
    Check out
    <a href="https://vuejs.org/guide/quick-start.html#local" target="_blank"
      >create-vue</a
    >, the official Vue + Vite starter
  </p>
  <p>
    Install
    <a href="https://github.com/johnsoncodehk/volar" target="_blank">Volar</a>
    in your IDE for a better DX
  </p>
  <p class="read-the-docs">Click on the Vite and Vue logos to learn more</p>
</template>

<style scoped>
.read-the-docs {
  color: #888;
}
</style>
