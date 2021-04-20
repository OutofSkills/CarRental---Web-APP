
// Initial Ratings
const ratings = {
    car_id_0: 4.7,
    car_id_1: 4.1,
    car_id_2: 2.7,
    car_id_3: 4.5,
    car_id_4: 3.7,
    car_id_5: 2.7,
    car_id_6: 1.7,
    car_id_7: 4.9
  }

  let arr=[];

    for (let el in ratings){
        arr.push(el)
    
    }

    // Total Stars
    const starsTotal = 5;

    // Run getRatings when DOM loads
    document.addEventListener('DOMContentLoaded', getRatings);
    
// Get ratings
function getRatings(rating) {
    for (let rating in ratings) {

      // Get percentage
      const starPercentage = (ratings[rating] / starsTotal) * 100;

      // Round to nearest 10
      const starPercentageRounded = `${Math.round(starPercentage / 10) * 10}%`;

      // Set width of stars-inner to percentage
      document.querySelector(`.${rating} .stars-inner`).style.width = starPercentageRounded;

      // Add number rating
     // document.querySelector(`.${rating} .number-rating`).innerHTML = ratings[rating];
    }
  }

