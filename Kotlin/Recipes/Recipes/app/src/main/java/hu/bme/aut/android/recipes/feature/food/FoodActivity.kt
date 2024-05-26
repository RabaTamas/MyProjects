package hu.bme.aut.android.recipes.feature.food

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import androidx.recyclerview.widget.LinearLayoutManager
import hu.bme.aut.android.recipes.R
import hu.bme.aut.android.recipes.databinding.ActivityFoodBinding
import kotlin.concurrent.thread
import hu.bme.aut.android.recipes.feature.details.DetailsActivity

class FoodActivity : AppCompatActivity(), FoodAdapter.OnFoodSelectedListener,
    AddFoodDialogFragment.AddFoodDialogListener {

    private lateinit var binding: ActivityFoodBinding
    private lateinit var adapter: FoodAdapter

    //private lateinit var database: FoodListDatabase

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityFoodBinding.inflate(layoutInflater)
        setContentView(binding.root)

        //database = FoodListDatabase.getDatabase(applicationContext)

        initFab()
        initRecyclerView()
    }

    private fun initFab() {
        binding.fab.setOnClickListener {
            // TODO: Show new food dialog
            binding.fab.setOnClickListener {
                AddFoodDialogFragment().show(supportFragmentManager, AddFoodDialogFragment::class.java.simpleName)
            }
        }
    }

    private fun initRecyclerView() {
        /*adapter = FoodAdapter(this)
        binding.rvFood.layoutManager = LinearLayoutManager(this)
        binding.rvMain.adapter = adapter
        loadItemsInBackground()*/

        binding.mainRecyclerView.layoutManager = LinearLayoutManager(this)
        adapter = FoodAdapter(this)
        adapter.addFood("rantotthus")
        adapter.addFood("lasagne")
        binding.mainRecyclerView.adapter = adapter
    }

    /*override fun onItemChanged(item: FoodItem) {
        thread {
            database.foodItemDao().update(item)
            Log.d("MainActivity", "FoodItem update was successful")
        }
    }*/

    override fun onFoodSelected(food: String?) {
        // Todo: Start DetailsActivity with the selected city
        val showDetailsIntent = Intent()
        showDetailsIntent.setClass(this@FoodActivity, DetailsActivity::class.java)
        showDetailsIntent.putExtra(DetailsActivity.EXTRA_FOOD_NAME, food)
        startActivity(showDetailsIntent)
    }

    override fun onFoodAdded(food: String?) {
        adapter.addFood(food!!)
    }
}